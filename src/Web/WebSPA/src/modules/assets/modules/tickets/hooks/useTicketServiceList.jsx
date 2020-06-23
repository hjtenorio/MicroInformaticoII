import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';
import { useIdentity } from '@valtx-mi2/identity';
import {
  makeTicketServiceListFetchRequestedSelector,
  makeTicketServiceListFetchSucceededSelector,
  makeTicketServiceListFetchFailedSelector,
  makeTicketServiceListSelector,
} from '../store/selectors';

import { ticketServiceListFetchAction } from '../store/actions';

function useTicketServiceList() {
  const dispatch = useDispatch();
  const identity = useIdentity();

  const {
    ticketServiceListFetchRequested,
    ticketServiceListFetchSucceeded,
    ticketServiceListFetchFailed,
    ticketServiceList,
  } = useSelector(
    createStructuredSelector({
      ticketServiceListFetchRequested: makeTicketServiceListFetchRequestedSelector(),
      ticketServiceListFetchSucceeded: makeTicketServiceListFetchSucceededSelector(),
      ticketServiceListFetchFailed: makeTicketServiceListFetchFailedSelector(),
      ticketServiceList: makeTicketServiceListSelector(),
    })
  );

  function ticketServiceListFetch() {
    dispatch(ticketServiceListFetchAction(identity));
  }

  return {
    ticketServiceListFetch,
    ticketServiceListFetchRequested,
    ticketServiceListFetchSucceeded,
    ticketServiceListFetchFailed,
    ticketServiceList,
  };
}

export default useTicketServiceList;
