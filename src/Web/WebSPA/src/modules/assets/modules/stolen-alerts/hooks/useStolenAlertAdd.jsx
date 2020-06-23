import { useIdentity } from '@valtx-mi2/identity';
import { useDispatch, useSelector } from 'react-redux';

import { createStructuredSelector } from 'reselect';
import { stolenAlertAddSubmitAction } from '../store/actions';
import {
  makeStolenAlertAddSubmitRequestedSelector,
  makeStolenAlertAddSubmitSucceededSelector,
  makeStolenAlertAddSubmitSucceededTicketNumberSelector,
  makeStolenAlertAddSubmitFailedSelector,
} from '../store/selectors';

function useStolenAlertAdd() {
  const identity = useIdentity();
  const dispatch = useDispatch();

  const {
    stolenAlertAddSubmitRequested,
    stolenAlertAddSubmitSucceeded,
    stolenAlertAddSubmitSucceededTicketNumber,
    stolenAlertAddSubmitFailed,
  } = useSelector(
    createStructuredSelector({
      stolenAlertAddSubmitRequested: makeStolenAlertAddSubmitRequestedSelector(),
      stolenAlertAddSubmitSucceeded: makeStolenAlertAddSubmitSucceededSelector(),
      stolenAlertAddSubmitSucceededTicketNumber: makeStolenAlertAddSubmitSucceededTicketNumberSelector(),
      stolenAlertAddSubmitFailed: makeStolenAlertAddSubmitFailedSelector(),
    })
  );

  function stolenAlertAddSubmit(params) {
    dispatch(stolenAlertAddSubmitAction(params, identity));
  }

  return {
    stolenAlertAddSubmit,
    stolenAlertAddSubmitRequested,
    stolenAlertAddSubmitSucceeded,
    stolenAlertAddSubmitSucceededTicketNumber,
    stolenAlertAddSubmitFailed,
  };
}

export default useStolenAlertAdd;
