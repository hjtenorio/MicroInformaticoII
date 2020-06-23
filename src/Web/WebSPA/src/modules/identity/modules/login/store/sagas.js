/* eslint-disable no-return-await */

import { all, call, put, takeLatest } from 'redux-saga/effects';

import IdentityAPI from '../../../api';
import { userLoginFailedAction, userLoginRequestedAction, userLoginSucceededAction } from './actions';
import { USER_LOGIN } from './types';

const authenticateAsync = async (username, password) =>
  await IdentityAPI.authenticate(username, password)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* userLoginSaga(action) {
  const { username, password } = action;
  try {
    // request
    yield put(userLoginRequestedAction());
    const response = yield call(authenticateAsync, username, password);
    // successs
    const { authToken: token, response: raisResponse, menu: raisMenu } = response;

    const user = {
      username: raisResponse.data.username,
      firstName: raisResponse.data.nombre,
      lastName: raisResponse.data.apellido,
      email: raisResponse.data.email,
    };
    const menu = raisMenu.menu.map((menuItem) => {
      return {
        id: menuItem.id,
        title: menuItem.title,
        children: menuItem.children,
      };
    });

    yield put(userLoginSucceededAction(user, token, menu));
  } catch (error) {
    // failed
    yield put(userLoginFailedAction(error.response.data));
  }
}

export default function* loginSaga() {
  yield all([takeLatest(USER_LOGIN, userLoginSaga)]);
}
