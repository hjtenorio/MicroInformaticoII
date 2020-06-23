/* eslint-disable no-return-await */
import { all, call, put, takeEvery } from 'redux-saga/effects';
import IdentityAPI from '../../../api';

import { resetPasswordFailed, resetPasswordSucceeded } from './actions';

import { RESET_PASSWORD_REQUESTED } from './types';

const resetPassword = async (token, password) =>
  await IdentityAPI.resetPassword(token, password)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* resetPasswordRequestedSaga(action) {
  const { token, password } = action;
  try {
    const response = yield call(resetPassword, token, password);
    yield put(resetPasswordSucceeded(response));
  } catch (error) {
    yield put(resetPasswordFailed(error));
  }
}

export default function* resetPasswordSaga() {
  yield all([takeEvery(RESET_PASSWORD_REQUESTED, resetPasswordRequestedSaga)]);
}
