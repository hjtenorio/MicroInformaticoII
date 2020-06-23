import { ASSETS_LIST_FETCH, ASSETS_LIST_FETCH_FAILED, ASSETS_LIST_FETCH_REQUESTED, ASSETS_LIST_FETCH_SUCCEEDED } from './types';

export function assetsListFetchAction(ownerId, identity) {
  return {
    type: ASSETS_LIST_FETCH,
    ownerId,
    identity,
  };
}

export function assetsListFetchRequestedAction() {
  return {
    type: ASSETS_LIST_FETCH_REQUESTED,
  };
}

export function assetsListFetchSucceededAction(data) {
  return {
    type: ASSETS_LIST_FETCH_SUCCEEDED,
    data,
  };
}

export function assetsListFetchFailedAction(error) {
  return {
    type: ASSETS_LIST_FETCH_FAILED,
    error,
  };
}
