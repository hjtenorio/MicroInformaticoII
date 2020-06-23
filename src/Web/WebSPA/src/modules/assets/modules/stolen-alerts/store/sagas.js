/* eslint-disable no-return-await */

import { all, call, put, takeEvery } from 'redux-saga/effects';

import AssetsAPI from '../../../api';
import { stolenAlertAddSubmitFailedAction, stolenAlertAddSubmitRequestedAction, stolenAlertAddSubmitSucceededAction } from './actions';
import { STOLEN_ALERT_ADD_SUBMIT } from './types';

const stolenAlertAddSubmitAsync = async (params, identity) =>
  await AssetsAPI.stolenAlertAddSubmit(params, identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* stolenAlertAddSubmitSaga(action) {
  try {
    const { params, identity } = action;
    // requested
    yield put(stolenAlertAddSubmitRequestedAction());
    const response = yield call(stolenAlertAddSubmitAsync, params, identity);

    // succeeded
    yield put(stolenAlertAddSubmitSucceededAction(response.result.ticketNumber));
  } catch (error) {
    // error
    yield put(stolenAlertAddSubmitFailedAction(error));
  }
}

export default function* stolenAlertSagas() {
  yield all([takeEvery(STOLEN_ALERT_ADD_SUBMIT, stolenAlertAddSubmitSaga)]);
}
