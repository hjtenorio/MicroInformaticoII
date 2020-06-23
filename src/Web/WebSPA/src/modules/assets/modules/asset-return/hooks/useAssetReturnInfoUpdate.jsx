import { useDispatch, useSelector } from 'react-redux';
import { useIdentity } from '@valtx-mi2/identity';
import { createStructuredSelector } from 'reselect';
import { assetReturnInfoUpdateSubmitAction } from '../store/actions';
import {
  makeAssetReturnInfoUpdateSubmitRequestedSelector,
  makeAssetReturnInfoUpdateSubmitSucceededSelector,
  makeAssetReturnInfoUpdateSubmitFailedSelector,
} from '../store/selectors';

function useAssetReturnInfoUpdate() {
  const dispatch = useDispatch();
  const identity = useIdentity();

  const {
    assetReturnInfoUpdateSubmitRequested,
    assetReturnInfoUpdateSubmitSucceeded,
    assetReturnInfoUpdateSubmitFailed,
  } = useSelector(
    createStructuredSelector({
      assetReturnInfoUpdateSubmitRequested: makeAssetReturnInfoUpdateSubmitRequestedSelector(),
      assetReturnInfoUpdateSubmitSucceeded: makeAssetReturnInfoUpdateSubmitSucceededSelector(),
      assetReturnInfoUpdateSubmitFailed: makeAssetReturnInfoUpdateSubmitFailedSelector(),
    })
  );

  function assetReturnInfoUpdateSubmit(transactionData) {
    dispatch(assetReturnInfoUpdateSubmitAction(transactionData, identity));
  }

  return {
    assetReturnInfoUpdateSubmit,
    assetReturnInfoUpdateSubmitRequested,
    assetReturnInfoUpdateSubmitSucceeded,
    assetReturnInfoUpdateSubmitFailed,
  };
}

export default useAssetReturnInfoUpdate;
