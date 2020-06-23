import { useEffect, useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';
import { fetchOtrsServices as fetchOtrsServicesAction } from '../store/actions';
import * as assetsCoreSelectors from '../store/selectors';

const {
  makeFetchOtrsServicesRequestedSelector,
  makeFetchOtrsServicesSucceededSelector,
  makeFetchOtrsServicesFailedSelector,
  makeOtrsServicesSelector,
} = assetsCoreSelectors;

const assetsCoreState = createStructuredSelector({
  fetchOtrsServicesRequested: makeFetchOtrsServicesRequestedSelector(),
  fetchOtrsServicesSucceeded: makeFetchOtrsServicesSucceededSelector(),
  fetchOtrsServicesFailed: makeFetchOtrsServicesFailedSelector(),
  otrsServices: makeOtrsServicesSelector(),
});

export default function useFetchOtrsServices(
  selectedOtrsServiceGroupId,
  identity
) {
  const dispatch = useDispatch();
  const {
    fetchOtrsServicesRequested,
    fetchOtrsServicesSucceeded,
    fetchOtrsServicesFailed,
    otrsServices,
  } = useSelector(assetsCoreState);

  const [loadingOtrsServices, setLoadingOtrsServices] = useState(false);

  // []
  useEffect(() => {
    if (selectedOtrsServiceGroupId) {
      dispatch(fetchOtrsServicesAction(selectedOtrsServiceGroupId, identity));
    }
  }, [selectedOtrsServiceGroupId]);

  // fetchOtrsServicesRequested
  useEffect(() => {
    if (fetchOtrsServicesRequested) {
      setLoadingOtrsServices(true);
    }
  }, [fetchOtrsServicesRequested]);

  // fetchOtrsServicesSucceeded
  useEffect(() => {
    if (fetchOtrsServicesSucceeded) {
      setLoadingOtrsServices(false);
    }
  }, [fetchOtrsServicesSucceeded]);

  // fetchOtrsServicesFailed
  useEffect(() => {
    if (fetchOtrsServicesFailed) {
      setLoadingOtrsServices(false);
    }
  }, [fetchOtrsServicesFailed]);

  return { otrsServices, loadingOtrsServices };
}
