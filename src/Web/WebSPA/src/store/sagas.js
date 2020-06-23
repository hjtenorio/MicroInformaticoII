import { sagas as identity } from '@valtx-mi2/identity';
import { sagas as assets } from '@valtx-mi2/assets';
import { all, fork } from 'redux-saga/effects';

export default function* rootSaga() {
  yield all([fork(identity), fork(assets)]);
}
