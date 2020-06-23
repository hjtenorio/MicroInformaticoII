/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */

import { LOCATION_CHANGE } from 'connected-react-router';
import produce, { setAutoFreeze } from 'immer';
import localForage from 'localforage';
import { persistReducer } from 'redux-persist';

import {
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH,
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_FAILED,
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_REQUESTED,
  ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_SUCCEEDED,
  ASSET_RETURN_INFO_UPDATE_SUBMIT,
  ASSET_RETURN_INFO_UPDATE_SUBMIT_FAILED,
  ASSET_RETURN_INFO_UPDATE_SUBMIT_REQUESTED,
  ASSET_RETURN_INFO_UPDATE_SUBMIT_SUCCEEDED,
} from './types';

const initialState = {
  assetReturnInfoPaginatedList: { data: [], count: 0 },
  assetReturnInfoPaginatedListFetchRequested: false,
  assetReturnInfoPaginatedListFetchSucceeded: false,
  assetReturnInfoPaginatedListFetchFailed: false,
  assetReturnInfoPaginatedListFetchError: null,
  assetReturnInfoUpdateSubmitRequested: false,
  assetReturnInfoUpdateSubmitSucceeded: false,
  assetReturnInfoUpdateSubmitFailed: false,
  assetReturnInfoUpdateSubmitError: null,
};

const persistConfig = {
  key: 'identity.assetReturnInfo',
  storage: localForage,
  blacklist: [
    'assetReturnInfoPaginatedList',
    'assetReturnInfoPaginatedListFetchRequested',
    'assetReturnInfoPaginatedListFetchSucceeded',
    'assetReturnInfoPaginatedListFetchFailed',
    'assetReturnInfoPaginatedListFetchError',
    'assetReturnInfoUpdateSubmitRequested',
    'assetReturnInfoUpdateSubmitSucceeded',
    'assetReturnInfoUpdateSubmitFailed',
    'assetReturnInfoUpdateSubmitError',
  ],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  switch (action.type) {
    case ASSET_RETURN_INFO_PAGINATED_LIST_FETCH:
      draft.assetReturnInfoPaginatedList = { data: [], count: 0 };

      draft.assetReturnInfoPaginatedListFetchRequested = false;
      draft.assetReturnInfoPaginatedListFetchSucceeded = false;
      draft.assetReturnInfoPaginatedListFetchFailed = false;
      draft.assetReturnInfoPaginatedListFetchError = null;
      break;
    case ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_REQUESTED:
      draft.assetReturnInfoPaginatedListFetchRequested = true;
      break;

    case ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_SUCCEEDED:
      draft.assetReturnInfoPaginatedListFetchRequested = false;
      draft.assetReturnInfoPaginatedListFetchSucceeded = true;
      draft.assetReturnInfoPaginatedList = action.paginatedList;
      break;

    case ASSET_RETURN_INFO_PAGINATED_LIST_FETCH_FAILED:
      draft.assetReturnInfoPaginatedListFetchRequested = false;
      draft.assetReturnInfoPaginatedListFetchFailed = true;
      draft.assetReturnInfoPaginatedListFetchError = action.error;
      break;

    case ASSET_RETURN_INFO_UPDATE_SUBMIT:
      draft.assetReturnInfoUpdateSubmitRequested = false;
      draft.assetReturnInfoUpdateSubmitSucceeded = false;
      draft.assetReturnInfoUpdateSubmitFailed = false;
      draft.assetReturnInfoUpdateSubmitError = null;
      break;

    case ASSET_RETURN_INFO_UPDATE_SUBMIT_REQUESTED:
      draft.assetReturnInfoUpdateSubmitRequested = true;
      break;

    case ASSET_RETURN_INFO_UPDATE_SUBMIT_SUCCEEDED:
      draft.assetReturnInfoUpdateSubmitRequested = false;
      draft.assetReturnInfoUpdateSubmitSucceeded = true;
      break;

    case ASSET_RETURN_INFO_UPDATE_SUBMIT_FAILED:
      draft.assetReturnInfoUpdateSubmitRequested = false;
      draft.assetReturnInfoUpdateSubmitFailed = true;
      draft.assetReturnInfoUpdateSubmitError = action.error;
      break;

    case LOCATION_CHANGE:
      console.log(action);
      draft.assetReturnInfoPaginatedList = { data: [], count: 0 };
      draft.assetReturnInfoPaginatedListFetchRequested = false;
      draft.assetReturnInfoPaginatedListFetchSucceeded = false;
      draft.assetReturnInfoPaginatedListFetchFailed = false;
      draft.assetReturnInfoPaginatedListFetchError = null;
      draft.assetReturnInfoUpdateSubmitRequested = false;
      draft.assetReturnInfoUpdateSubmitSucceeded = false;
      draft.assetReturnInfoUpdateSubmitFailed = false;
      draft.assetReturnInfoUpdateSubmitError = null;
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
