import { createSelector } from 'reselect';

import { initialState } from './reducers';

const assetsCoreState = (state) => state.assets.core || initialState;

export const makeAssetsListFetchRequestedSelector = () => createSelector(assetsCoreState, (state) => state.assetsListFetchRequested);
export const makeAssetsListFetchSucceededSelector = () => createSelector(assetsCoreState, (state) => state.assetsListFetchSucceeded);
export const makeAssetsListFetchFailedSelector = () => createSelector(assetsCoreState, (state) => state.assetsListFetchFailed);
export const makeAssetsListSelector = () => createSelector(assetsCoreState, (state) => state.assetsList);
