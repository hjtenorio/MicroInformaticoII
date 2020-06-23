/* eslint-disable no-unused-vars */
import { all, fork } from 'redux-saga/effects';
import loginSagas from '../modules/login/store/sagas';
import forgotPasswordSagas from '../modules/forgot-password/store/sagas';
import resetPasswordSagas from '../modules/reset-password/store/sagas';

export default function* rootSaga() {
  yield all([fork(forgotPasswordSagas), fork(loginSagas), fork(resetPasswordSagas), fork(forgotPasswordSagas)]);
}
