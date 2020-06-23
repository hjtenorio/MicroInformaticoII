import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';

import { useIdentity } from '@valtx-mi2/identity';

import { ticketPaginatedListFetchAction } from '../store/actions';
import {
  makeTicketPaginatedListFetchRequestedSelector,
  makeTicketPaginatedListFetchSucceededSelector,
  makeTicketPaginatedListSelector,
} from '../store/selectors';

function useTicketPaginatedList() {
  const dispatch = useDispatch();
  const identity = useIdentity();
  const {
    ticketPaginatedList,
    ticketPaginatedListFetchRequested,
    ticketPaginatedListFetchSucceeded,
  } = useSelector(
    createStructuredSelector({
      ticketPaginatedList: makeTicketPaginatedListSelector(),
      ticketPaginatedListFetchRequested: makeTicketPaginatedListFetchRequestedSelector(),
      ticketPaginatedListFetchSucceeded: makeTicketPaginatedListFetchSucceededSelector(),
    })
  );

  function ticketPaginatedListFetch(params, currentPage, pageSize) {
    dispatch(
      ticketPaginatedListFetchAction(params, currentPage, pageSize, identity)
    );
  }

  return {
    ticketPaginatedList,
    ticketPaginatedListFetch,
    ticketPaginatedListFetchRequested,
    ticketPaginatedListFetchSucceeded,
  };
}

export default useTicketPaginatedList;
