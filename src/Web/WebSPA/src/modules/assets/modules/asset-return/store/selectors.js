import { createSelector } from 'reselect';

import { initialState } from './reducers';

const assetReturnInfoState = (state) => state.assets.assetReturn || initialState;

const makeAssetReturnInfoPaginatedListSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoPaginatedList);

const makeAssetReturnInfoPaginatedListCountSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoPaginatedListCount);

const makeAssetReturnInfoPaginatedListFetchRequestedSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoPaginatedListFetchRequested);

const makeAssetReturnInfoPaginatedListFetchSucceededSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoPaginatedListFetchSucceeded);

const makeAssetReturnInfoPaginatedListFetchFailedSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoPaginatedListFetchFailed);

const makeAssetReturnInfoPaginatedListFetchErrorSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoPaginatedListFetchError);

const makeAssetReturnInfoUpdateSubmitRequestedSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoUpdateSubmitRequested);

const makeAssetReturnInfoUpdateSubmitSucceededSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoUpdateSubmitSucceeded);

const makeAssetReturnInfoUpdateSubmitFailedSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoUpdateSubmitFailed);

const makeAssetReturnInfoUpdateSubmitErrorSelector = () => createSelector(assetReturnInfoState, (state) => state.assetReturnInfoUpdateSubmitError);

export {
  makeAssetReturnInfoPaginatedListSelector,
  makeAssetReturnInfoPaginatedListCountSelector,
  makeAssetReturnInfoPaginatedListFetchRequestedSelector,
  makeAssetReturnInfoPaginatedListFetchSucceededSelector,
  makeAssetReturnInfoPaginatedListFetchFailedSelector,
  makeAssetReturnInfoPaginatedListFetchErrorSelector,
  makeAssetReturnInfoUpdateSubmitRequestedSelector,
  makeAssetReturnInfoUpdateSubmitSucceededSelector,
  makeAssetReturnInfoUpdateSubmitFailedSelector,
  makeAssetReturnInfoUpdateSubmitErrorSelector,
};
