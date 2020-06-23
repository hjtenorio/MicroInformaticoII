/* eslint-disable no-return-await */

import { all, call, put, takeEvery } from 'redux-saga/effects';

import AssetsAPI from '../../../core/api';
import {
  ticketAddSubmitFailedAction,
  ticketAddSubmitRequestedAction,
  ticketAddSubmitSucceededAction,
  ticketAddSubmitFailedAction,
  ticketDetailUpdateSubmitRequestedAction,
  ticketDetailUpdateSubmitSucceededAction,
  ticketDetailUpdateSubmitFailedAction,
  ticketPaginatedListFetchRequestedAction,
  ticketPaginatedListFetchSucceededAction,
  ticketPaginatedListFetchFailedAction,
  ticketStatusListFetchFailedAction,
  ticketStatusListFetchRequestedAction,
  ticketStatusListFetchSucceededAction,
  ticketStatusDataFetchRequestedAction,
  ticketStatusDataFetchSucceededAction,
  ticketStatusDataFetchFailedAction,
  ticketDetailDataFetchFailedAction,
  ticketDetailDataFetchRequestedAction,
  ticketDetailDataFetchSucceededAction,
  ticketPaginatedListFetchFailedAction,
  ticketPaginatedListFetchRequestedAction,
  ticketPaginatedListFetchSucceededAction,
  ticketQueueDetailDataFetchFailedAction,
  ticketQueueDetailDataFetchRequestedAction,
  ticketQueueDetailDataFetchSucceededAction,
  ticketServiceListFetchFailedAction,
  ticketServiceListFetchRequestedAction,
  ticketServiceListFetchSucceededAction,
  ticketStatusDataFetchFailedAction,
  ticketStatusDataFetchRequestedAction,
  ticketStatusDataFetchSucceededAction,
  ticketStatusListFetchFailedAction,
  ticketStatusListFetchRequestedAction,
  ticketStatusListFetchSucceededAction,
} from './actions';
import {
  TICKET_ADD_SUBMIT,
  TICKET_DETAIL_UPDATE_SUBMIT,
  TICKET_PAGINATED_LIST_FETCH,
  TICKET_STATUS_LIST_FETCH,
  TICKET_STATUS_DATA_FETCH,
  TICKET_DETAIL_DATA_FETCH,
  TICKET_PAGINATED_LIST_FETCH,
  TICKET_QUEUE_DETAIL_DATA_FETCH,
  TICKET_SERVICE_LIST_FETCH,
  TICKET_STATUS_DATA_FETCH,
  TICKET_STATUS_LIST_FETCH,
} from './types';

/*
 * Ticket Detail Update Submit
 */

const ticketDetailUpdateSubmitAsync = async (params, identity) =>
  await AssetsAPI.ticketDetailUpdateSubmit(params, identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* ticketDetailUpdateSubmitSaga(action) {
  try {
    const { params, identity } = action;
    // requested
    yield put(ticketDetailUpdateSubmitRequestedAction());
    yield call(ticketDetailUpdateSubmitAsync, params, identity);
    // succeeded
    yield put(ticketDetailUpdateSubmitSucceededAction());
  } catch (error) {
    // error
    yield put(ticketDetailUpdateSubmitFailedAction(error));
  }
}

/*
 * Ticket Service List Fetch
 */

const ticketServiceListFetchAsync = async (identity) =>
  await AssetsAPI.ticketServiceListFetch(identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* ticketServiceListFetchSaga(action) {
  try {
    const { identity } = action;
    // requested
    yield put(ticketServiceListFetchRequestedAction());
    const data = yield call(ticketServiceListFetchAsync, identity);
    // succeeded
    console.log(data);
    yield put(ticketServiceListFetchSucceededAction(data));
  } catch (error) {
    // error
    yield put(ticketServiceListFetchFailedAction(error));
  }
}

const ticketAddSubmitAsync = async (params, identity) =>
  await AssetsAPI.ticketAddSubmit(params, identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* ticketAddSubmitSaga(action) {
  try {
    const { params, identity } = action;
    // requested
    yield put(ticketAddSubmitRequestedAction());
    const response = yield call(ticketAddSubmitAsync, params, identity);
    // succeeded
    yield put(ticketAddSubmitSucceededAction(response.result.ticketNumber));
  } catch (error) {
    // error
    yield put(ticketAddSubmitFailedAction(error));
  }
}

/*
 * Ticket Paginated List Fetch
 */
const ticketPaginatedListFetchAsync = async (params, currentPage, pageSize, identity) =>
  await AssetsAPI.ticketPaginatedListFetch(params, currentPage, pageSize, identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* ticketPaginatedListFetchSaga(action) {
  try {
    const { params, currentPage, pageSize, identity } = action;

    // requested
    yield put(ticketPaginatedListFetchRequestedAction());
    const paginatedList = yield call(ticketPaginatedListFetchAsync, params, currentPage, pageSize, identity);
    console.log('params', params);
    console.log('currentPage', currentPage);
    console.log('pageSize', pageSize);
    console.log('identity', identity);

    // succeeded
    yield put(ticketPaginatedListFetchSucceededAction(paginatedList));
  } catch (error) {
    // error
    yield put(ticketPaginatedListFetchFailedAction(error));
  }
}

/*
 * Ticket Status List Fetch
 */

const ticketStatusListFetchAsync = async (identity) =>
  await AssetsAPI.ticketStatusListFetch(identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* ticketStatusListFetchSaga(action) {
  try {
    const { identity } = action;
    // requested
    yield put(ticketStatusListFetchRequestedAction());
    const ticketStatusList = yield call(ticketStatusListFetchAsync, identity);
    // succeeded
    yield put(ticketStatusListFetchSucceededAction(ticketStatusList));
  } catch (error) {
    // error
    yield put(ticketStatusListFetchFailedAction(error));
  }
}

const ticketStatusDataFetchRequest = async (identity, ticketId) =>
  await AssetsAPI.ticketStatusDataFetchRequestAsync(identity, ticketId)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

const ticketDetailDataFetchAsync = async (identity, ticketId) =>
  await AssetsAPI.ticketDetailDataFetchAsync(identity, ticketId)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

const ticketQueueDetailDataFetchAsync = async (identity, ticketId, queue) =>
  await AssetsAPI.ticketQueueDetailDataFetchAsync(identity, ticketId, queue)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* ticketStatusDataFetchSaga(action) {
  try {
    const { identity, ticketId } = action;
    // requested
    yield put(ticketStatusDataFetchRequestedAction());
    const response = yield call(ticketStatusDataFetchRequest, identity, ticketId);
    console.log(response);
    // succeeded
    yield put(ticketStatusDataFetchSucceededAction(response));
  } catch (error) {
    // error
    yield put(ticketStatusDataFetchFailedAction(error));
  }
}

function* ticketDetailDataFetchSaga(action) {
  try {
    const { identity, ticketId } = action;
    // requested
    yield put(ticketDetailDataFetchRequestedAction());
    const response = yield call(ticketDetailDataFetchAsync, identity, ticketId);
    // succeeded
    yield put(ticketDetailDataFetchSucceededAction(response));
    console.log(response);
  } catch (error) {
    // error
    yield put(ticketDetailDataFetchFailedAction(error));
  }
}

function* ticketQueueDetailDataFetchSaga(action) {
  try {
    const { identity, ticketId, queue } = action;
    // requested
    yield put(ticketQueueDetailDataFetchRequestedAction());
    const data = yield call(ticketQueueDetailDataFetchAsync, identity, ticketId, queue);
    // succeeded
    yield put(ticketQueueDetailDataFetchSucceededAction(data));
  } catch (error) {
    // error
    yield put(ticketQueueDetailDataFetchFailedAction(error));
  }
}

export default function* ticketAddSagas() {
  yield all([
    takeEvery(TICKET_ADD_SUBMIT, ticketAddSubmitSaga),
    takeEvery(TICKET_PAGINATED_LIST_FETCH, ticketPaginatedListFetchSaga),
    takeEvery(TICKET_SERVICE_LIST_FETCH, ticketServiceListFetchSaga),
    takeEvery(TICKET_STATUS_LIST_FETCH, ticketStatusListFetchSaga),
    takeEvery(TICKET_STATUS_DATA_FETCH, ticketStatusDataFetchSaga),
    takeEvery(TICKET_DETAIL_DATA_FETCH, ticketDetailDataFetchSaga),
    takeEvery(TICKET_QUEUE_DETAIL_DATA_FETCH, ticketQueueDetailDataFetchSaga),
    takeEvery(TICKET_DETAIL_UPDATE_SUBMIT, ticketDetailUpdateSubmitSaga),
  ]);
}
