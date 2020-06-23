/* eslint-disable no-use-before-define */
/*
 * @Author: gvillena
 * @Date: 2020-03-02 13:26:11
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-02 18:44:16
 */
import React, { useState, useEffect } from 'react';
import { useIdentity } from '@valtx-mi2/identity';
import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';
import { ticketDetailDataFetchAction } from '../store/actions';

import {
  makeTicketDetailDataSelector,
  makeTicketDetailDataFetchRequestedSelector,
  makeTicketDetailDataFetchSucceededSelector,
  makeTicketDetailDataFetchFailedSelector,
} from '../store/selectors';

const selector = createStructuredSelector({
  ticketDetailData: makeTicketDetailDataSelector(),
  ticketDetailDataFetchRequested: makeTicketDetailDataFetchRequestedSelector(),
  ticketDetailDataFetchSucceeded: makeTicketDetailDataFetchSucceededSelector(),
  ticketDetailDataFetchFailed: makeTicketDetailDataFetchFailedSelector(),
});

function useTicketDetailData() {
  const identity = useIdentity();
  const dispatch = useDispatch();
  const {
    ticketDetailData,
    ticketDetailDataFetchRequested,
    ticketDetailDataFetchSucceeded,
    ticketDetailDataFetchFailed,
  } = useSelector(selector);

  const [data, setData] = useState({});
  const [isLoading, setIsLoading] = useState(false);

  useEffect(() => {
    if (ticketDetailDataFetchRequested) {
      onTicketDetailDataFetchRequested();
    }

    if (ticketDetailDataFetchSucceeded) {
      onTicketDetailDataFetchSucceeded();
    }

    if (ticketDetailDataFetchFailed) {
      onTicketDetailDataFetchFailed();
    }
  }, [
    ticketDetailDataFetchRequested,
    ticketDetailDataFetchSucceeded,
    ticketDetailDataFetchRequested,
  ]);

  function onTicketDetailDataFetchRequested() {
    setIsLoading(true);
    setData([]);
  }

  function onTicketDetailDataFetchSucceeded() {
    setIsLoading(false);
    setData(ticketDetailData);
  }

  function onTicketDetailDataFetchFailed() {
    setIsLoading(false);
    setData([]);
    console.log('error');
  }

  const fetch = (ticketId) => {
    setIsLoading(true);
    dispatch(ticketDetailDataFetchAction(identity, ticketId));
  };

  return [data, fetch, isLoading];
}

export default useTicketDetailData;
