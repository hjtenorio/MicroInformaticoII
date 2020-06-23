import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';

import { useIdentity } from '@valtx-mi2/identity';

import { assetsListFetchAction } from '../store/actions';
import * as selectors from '../store/selectors';

const {
  makeAssetsListFetchRequestedSelector,
  makeAssetsListFetchSucceededSelector,
  makeAssetsListFetchFailedSelector,
  makeAssetsListSelector,
} = selectors;

function useAssetsList() {
  const dispatch = useDispatch();
  const identity = useIdentity();

  const {
    assetsListFetchRequested,
    assetsListFetchSucceeded,
    assetsListFetchFailed,
    assetsList,
  } = useSelector(
    createStructuredSelector({
      assetsListFetchRequested: makeAssetsListFetchRequestedSelector(),
      assetsListFetchSucceeded: makeAssetsListFetchSucceededSelector(),
      assetsListFetchFailed: makeAssetsListFetchFailedSelector(),
      assetsList: makeAssetsListSelector(),
    })
  );

  function assetsListFetch(ownerId) {
    dispatch(assetsListFetchAction(ownerId, identity));
  }

  return {
    assetsList,
    assetsListFetch,
    assetsListFetchRequested,
    assetsListFetchSucceeded,
    assetsListFetchFailed,
  };
}

export default useAssetsList;
