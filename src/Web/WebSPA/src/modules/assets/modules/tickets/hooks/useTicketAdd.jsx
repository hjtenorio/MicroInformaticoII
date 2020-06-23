import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';
import { useIdentity } from '@valtx-mi2/identity';
import { ticketAddSubmitAction } from '../store/actions';
import {
  makeTicketAddSubmitRequestedSelector,
  makeTicketAddSubmitSucceededSelector,
  makeTicketAddSubmitFailedSelector,
  makeTicketAddSubmitSucceededTicketNumberSelector,
} from '../store/selectors';

function useTicketAdd() {
  const dispatch = useDispatch();
  const identity = useIdentity();

  const {
    ticketAddSubmitRequested,
    ticketAddSubmitSucceeded,
    ticketAddSubmitSucceededTicketNumber,
    ticketAddSubmitFailed,
  } = useSelector(
    createStructuredSelector({
      ticketAddSubmitRequested: makeTicketAddSubmitRequestedSelector(),
      ticketAddSubmitSucceeded: makeTicketAddSubmitSucceededSelector(),
      ticketAddSubmitSucceededTicketNumber: makeTicketAddSubmitSucceededTicketNumberSelector(),
      ticketAddSubmitFailed: makeTicketAddSubmitFailedSelector(),
    })
  );

  function ticketAddSubmit(params) {
    dispatch(ticketAddSubmitAction(params, identity));
  }

  return {
    ticketAddSubmit,
    ticketAddSubmitRequested,
    ticketAddSubmitSucceeded,
    ticketAddSubmitSucceededTicketNumber,
    ticketAddSubmitFailed,
  };
}

export default useTicketAdd;
