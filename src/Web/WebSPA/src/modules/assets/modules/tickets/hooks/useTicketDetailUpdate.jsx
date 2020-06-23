import React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { useIdentity } from '@valtx-mi2/identity';

import { createStructuredSelector } from 'reselect';
import { ticketDetailUpdateSubmitAction } from '../store/actions';
import {
  makeTicketDetailUpdateSubmitRequestedSelector,
  makeTicketDetailUpdateSubmitSucceededSelector,
  makeTicketDetailUpdateSubmitFailedSelector,
} from '../store/selectors';

export default function useTicketDetailUpdate() {
  const dispatch = useDispatch();
  const identity = useIdentity();

  const {
    ticketDetailUpdateSubmitRequested,
    ticketDetailUpdateSubmitSucceeded,
    ticketDetailUpdateSubmitFailed,
  } = useSelector(
    createStructuredSelector({
      ticketDetailUpdateSubmitRequested: makeTicketDetailUpdateSubmitRequestedSelector(),
      ticketDetailUpdateSubmitSucceeded: makeTicketDetailUpdateSubmitSucceededSelector(),
      ticketDetailUpdateSubmitFailed: makeTicketDetailUpdateSubmitFailedSelector(),
    })
  );

  function ticketDetailUpdateSubmit(params) {
    dispatch(ticketDetailUpdateSubmitAction(params, identity));
  }

  return {
    ticketDetailUpdateSubmit,
    ticketDetailUpdateSubmitRequested,
    ticketDetailUpdateSubmitSucceeded,
    ticketDetailUpdateSubmitFailed,
  };
}
