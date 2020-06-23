/* eslint-disable no-return-await */

import { all, fork } from 'redux-saga/effects';

import assetReturnSagas from '../modules/asset-return/store/sagas';
import coreSagas from '../modules/core/store/sagas';
import stolenAlertSagas from '../modules/stolen-alerts/store/sagas';
import ticketsSagas from '../modules/tickets/store/sagas';

export default function* rootSaga() {
  yield all([fork(coreSagas), fork(ticketsSagas), fork(assetReturnSagas), fork(stolenAlertSagas)]);
}
