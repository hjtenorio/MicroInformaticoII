/*
 * @Author: gvillena
 * @Date: 2020-02-24 17:19:44
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-02-24 17:49:25
 */
/* eslint-disable no-return-await */

import { all, call, put, takeEvery } from 'redux-saga/effects';

import AssetAPI from '../../../api';
import {
  assetReturnInfoPaginatedListFetchFailedAction,
  assetReturnInfoPaginatedListFetchRequestedAction,
  assetReturnInfoPaginatedListFetchSucceededAction,
  assetReturnInfoUpdateSubmitFailedAction,
  assetReturnInfoUpdateSubmitRequestedAction,
  assetReturnInfoUpdateSubmitSucceededAction,
} from './actions';
import { ASSET_RETURN_INFO_PAGINATED_LIST_FETCH, ASSET_RETURN_INFO_UPDATE_SUBMIT } from './types';

const assetReturnInfoPaginatedListFetchAsync = async (params, currentPage, pageSize, identity) =>
  await AssetAPI.assetReturnInfoPaginatedListFetch(params, currentPage, pageSize, identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* assetReturnInfoPaginatedListFetchSaga(action) {
  try {
    const { identity, params, currentPage, pageSize } = action;
    yield put(assetReturnInfoPaginatedListFetchRequestedAction());

    const paginatedList = yield call(assetReturnInfoPaginatedListFetchAsync, params, currentPage, pageSize, identity);
    yield put(assetReturnInfoPaginatedListFetchSucceededAction(paginatedList));
  } catch (error) {
    yield put(assetReturnInfoPaginatedListFetchFailedAction(error));
  }
}

const assetReturnInfoUpdateSubmitAsync = async (transactionData, identity) => {
  return await AssetAPI.assetReturnInfoUpdateSubmit(transactionData, identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });
};

function* assetReturnInfoUpdateSubmitSaga(action) {
  try {
    const { identity, transactionData } = action;
    yield put(assetReturnInfoUpdateSubmitRequestedAction());
    const response = yield call(assetReturnInfoUpdateSubmitAsync, transactionData, identity);

    yield put(assetReturnInfoUpdateSubmitSucceededAction(response.data));
  } catch (error) {
    yield put(assetReturnInfoUpdateSubmitFailedAction(error));
  }
}

export default function* rootSaga() {
  yield all([takeEvery(ASSET_RETURN_INFO_PAGINATED_LIST_FETCH, assetReturnInfoPaginatedListFetchSaga), takeEvery(ASSET_RETURN_INFO_UPDATE_SUBMIT, assetReturnInfoUpdateSubmitSaga)]);
}
