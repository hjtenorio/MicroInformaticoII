import { useState, useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';

import { useIdentity } from '@valtx-mi2/identity';
import { createStructuredSelector } from 'reselect';

import {
  makeTicketStatusDataSelector,
  makeTicketStatusDataFetchRequestedSelector,
  makeTicketStatusDataFetchSucceededSelector,
  makeTicketStatusDataFetchFailedSelector,
  makeTicketStatusDataFetchErrorMessageSelector,
} from '../store/selectors';

import { ticketStatusDataFetchAction } from '../store/actions';

const selector = createStructuredSelector({
  ticketStatusData: makeTicketStatusDataSelector(),
  ticketStatusDataFetchRequested: makeTicketStatusDataFetchRequestedSelector(),
  ticketStatusDataFetchSucceeded: makeTicketStatusDataFetchSucceededSelector(),
  ticketStatusDataFetchFailed: makeTicketStatusDataFetchFailedSelector(),
  ticketStatusDataFetchErrorMessage: makeTicketStatusDataFetchErrorMessageSelector(),
});

/**
 * useTicketProgressFlowDataFetch
 *
 * @param {*} props
 */
function useTicketStatusData() {
  const dispatch = useDispatch();
  const {
    ticketStatusData,
    ticketStatusDataFetchRequested,
    ticketStatusDataFetchSucceeded,
    ticketStatusDataFetchFailed,
  } = useSelector(selector);

  const identity = useIdentity();
  const [isLoading, setIsLoading] = useState(true);
  const [data, setData] = useState([]);

  const fetch = (ticketId) => {
    dispatch(ticketStatusDataFetchAction(identity, ticketId));
  };

  function onTicketStatusDataFetchRequested() {
    setData([]);
    setIsLoading(true);
  }

  function onTicketStatusDataFetchSucceeded() {
    setData(ticketStatusData);
    setIsLoading(false);
  }

  function onTicketStatusDataFetchFailed() {
    console.log();
  }

  useEffect(() => {
    if (ticketStatusDataFetchRequested) onTicketStatusDataFetchRequested();
    if (ticketStatusDataFetchSucceeded) onTicketStatusDataFetchSucceeded();
    if (ticketStatusDataFetchFailed) onTicketStatusDataFetchFailed();
  }, [
    ticketStatusDataFetchRequested,
    ticketStatusDataFetchSucceeded,
    ticketStatusDataFetchFailed,
  ]);

  return [data, fetch, isLoading];
}

export default useTicketStatusData;
