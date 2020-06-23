import { useDispatch, useSelector } from 'react-redux';
import { useIdentity } from '@valtx-mi2/identity';

import { createStructuredSelector } from 'reselect';
import { assetReturnInfoPaginatedListFetchAction } from '../store/actions';
import {
  makeAssetReturnInfoPaginatedListSelector,
  makeAssetReturnInfoPaginatedListFetchRequestedSelector,
  makeAssetReturnInfoPaginatedListFetchSucceededSelector,
  makeAssetReturnInfoPaginatedListFetchFailedSelector,
} from '../store/selectors';

function useAssetReturnInfoPaginatedList() {
  const dispatch = useDispatch();
  const identity = useIdentity();

  const {
    assetReturnInfoPaginatedList,
    assetReturnInfoPaginatedListFetchRequested,
    assetReturnInfoPaginatedListFetchSucceeded,
    assetReturnInfoPaginatedListFetchFailed,
  } = useSelector(
    createStructuredSelector({
      assetReturnInfoPaginatedList: makeAssetReturnInfoPaginatedListSelector(),
      assetReturnInfoPaginatedListFetchRequested: makeAssetReturnInfoPaginatedListFetchRequestedSelector(),
      assetReturnInfoPaginatedListFetchSucceeded: makeAssetReturnInfoPaginatedListFetchSucceededSelector(),
      assetReturnInfoPaginatedListFetchFailed: makeAssetReturnInfoPaginatedListFetchFailedSelector(),
    })
  );

  function assetReturnInfoPaginatedListFetch(params, currentPage, pageIndex) {
    dispatch(
      assetReturnInfoPaginatedListFetchAction(
        params,
        currentPage,
        pageIndex,
        identity
      )
    );
  }

  return {
    assetReturnInfoPaginatedList,
    assetReturnInfoPaginatedListFetch,
    assetReturnInfoPaginatedListFetchRequested,
    assetReturnInfoPaginatedListFetchSucceeded,
    assetReturnInfoPaginatedListFetchFailed,
  };
}

export default useAssetReturnInfoPaginatedList;
