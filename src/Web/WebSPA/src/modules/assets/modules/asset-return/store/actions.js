/*
 * @Author: gvillena
 * @Date: 2020-02-24 11:56:39
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-02-24 17:39:10
 */
import {
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH,
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_REQUESTED,
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_SUCCEEDED,
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_FAILED,
  ASSET_RETURN_INFO_UPDATE_SUBMIT,
  ASSET_RETURN_INFO_UPDATE_SUBMIT_REQUESTED,
  ASSET_RETURN_INFO_UPDATE_SUBMIT_SUCCEEDED,
  ASSET_RETURN_INFO_UPDATE_SUBMIT_FAILED,
} from './types';

/**
 * assetReturnInfoPaginatedListFetchAction
 *
 * @param {*} identity
 * @param {*} searchParams
 * @returns
 */
function assetReturnInfoPaginatedListFetchAction(params, currentPage, pageSize, identity) {
  return {
    type: ASSET_RETURN_INFO_PAGINATED_LIST_FETCH,
    identity,
    params,
    currentPage,
    pageSize,
  };
}

/**
 * assetReturnInfoPaginatedListFetchRequestedAction
 *
 * @returns
 */
function assetReturnInfoPaginatedListFetchRequestedAction() {
  return {
    type: ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_REQUESTED,
  };
}

/**
 * assetReturnInfoPaginatedListFetchSucceededAction
 *
 * @param {*} data
 * @returns
 */
function assetReturnInfoPaginatedListFetchSucceededAction(paginatedList) {
  return {
    type: ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_SUCCEEDED,
    paginatedList,
  };
}

/**
 * assetReturnInfoPaginatedListFetchFailedAction
 *
 * @param {*} error
 * @returns
 */
function assetReturnInfoPaginatedListFetchFailedAction(error) {
  return {
    type: ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_FAILED,
    error,
  };
}

/**
 * assetReturnInfoUpdateSubmit
 *
 * @returns
 */
function assetReturnInfoUpdateSubmitAction(transactionData, identity) {
  return {
    type: ASSET_RETURN_INFO_UPDATE_SUBMIT,
    transactionData,
    identity,
  };
}

/**
 * assetReturnInfoUpdateSubmitRequested
 *
 * @returns
 */
function assetReturnInfoUpdateSubmitRequestedAction() {
  return {
    type: ASSET_RETURN_INFO_UPDATE_SUBMIT_REQUESTED,
  };
}

/**
 * assetReturnInfoUpdateSubmitSucceeded
 *
 * @returns
 */
function assetReturnInfoUpdateSubmitSucceededAction() {
  return {
    type: ASSET_RETURN_INFO_UPDATE_SUBMIT_SUCCEEDED,
  };
}

/**
 * assetReturnInfoUpdateSubmitFailed
 *
 * @returns
 */
function assetReturnInfoUpdateSubmitFailedAction(error) {
  return {
    type: ASSET_RETURN_INFO_UPDATE_SUBMIT_FAILED,
    error,
  };
}

export {
  assetReturnInfoPaginatedListFetchAction,
  assetReturnInfoPaginatedListFetchRequestedAction,
  assetReturnInfoPaginatedListFetchSucceededAction,
  assetReturnInfoPaginatedListFetchFailedAction,
  assetReturnInfoUpdateSubmitAction,
  assetReturnInfoUpdateSubmitRequestedAction,
  assetReturnInfoUpdateSubmitSucceededAction,
  assetReturnInfoUpdateSubmitFailedAction,
};
