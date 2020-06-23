/* eslint-disable no-param-reassign */
/* eslint-disable default-case */

import produce, { setAutoFreeze } from 'immer';
import localForage from 'localforage';
import { persistReducer } from 'redux-persist';

import { ASSETS_LIST_FETCH, ASSETS_LIST_FETCH_FAILED, ASSETS_LIST_FETCH_REQUESTED, ASSETS_LIST_FETCH_SUCCEEDED } from './types';

const initialState = {
  assetsListFetchRequested: false,
  assetsListFetchSucceeded: false,
  assetsListFetchFailed: false,
  assetsList: [],
};

const persistConfig = {
  key: 'assets.core',
  storage: localForage,
  blacklist: ['assetsListFetchRequested', 'assetsListFetchSucceeded', 'assetsListFetchFailed', 'assetsList'],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  switch (action.type) {
    case ASSETS_LIST_FETCH:
      draft.assetsList = [];
      draft.assetsListFetchRequested = false;
      draft.assetsListFetchSucceeded = false;
      draft.assetsListFetchFailed = false;
      break;

    case ASSETS_LIST_FETCH_REQUESTED:
      draft.assetsListFetchRequested = true;
      break;

    case ASSETS_LIST_FETCH_SUCCEEDED:
      draft.assetsListFetchRequested = false;
      draft.assetsListFetchSucceeded = true;
      draft.assetsList = action.data;
      break;

    case ASSETS_LIST_FETCH_FAILED:
      draft.assetsListFetchRequested = false;
      draft.assetsListFetchFailed = true;
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
