/* eslint-disable no-return-await */
import { all, call, put, takeEvery } from 'redux-saga/effects';
import IdentityAPI from '../../../api';

import { forgotPasswordFailed, forgotPasswordSucceeded } from './actions';

import { FORGOT_PASSWORD_REQUESTED } from './types';

const forgotPassword = async (dni) =>
  await IdentityAPI.forgotPassword(dni)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* forgotPasswordRequestedSaga(action) {
  const { dni } = action;
  try {
    const response = yield call(forgotPassword, dni);
    yield put(forgotPasswordSucceeded(response));
  } catch (error) {
    yield put(forgotPasswordFailed(error));
  }
}

export default function* forgotPasswordSaga() {
  yield all([
    takeEvery(FORGOT_PASSWORD_REQUESTED, forgotPasswordRequestedSaga),
  ]);
}
