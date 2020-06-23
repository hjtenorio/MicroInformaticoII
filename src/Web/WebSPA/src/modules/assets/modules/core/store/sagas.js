import { all, call, put, takeLatest } from 'redux-saga/effects';

import AssetsAPI from '../../../api';
import { assetsListFetchFailedAction, assetsListFetchRequestedAction, assetsListFetchSucceededAction } from './actions';
import { ASSETS_LIST_FETCH } from './types';

const assetsListFetchAsync = async (ownerId, identity) =>
  // eslint-disable-next-line no-return-await
  await AssetsAPI.fetch(ownerId, identity)
    .then((response) => response.data)
    .catch((error) => {
      throw error;
    });

function* assetsListFetchSaga(action) {
  try {
    const { ownerId, identity } = action;
    // requested
    yield put(assetsListFetchRequestedAction());
    const assetsList = yield call(assetsListFetchAsync, ownerId, identity);
    // succeeded
    yield put(assetsListFetchSucceededAction(assetsList));
  } catch (error) {
    // error
    yield put(assetsListFetchFailedAction(error));
  }
}

export default function* rootSaga() {
  yield all([takeLatest(ASSETS_LIST_FETCH, assetsListFetchSaga)]);
}
