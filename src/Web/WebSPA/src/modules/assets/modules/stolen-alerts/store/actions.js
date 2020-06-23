/* eslint-disable import/prefer-default-export */
import { STOLEN_ALERT_ADD_SUBMIT, STOLEN_ALERT_ADD_SUBMIT_REQUESTED, STOLEN_ALERT_ADD_SUBMIT_SUCCEEDED, STOLEN_ALERT_ADD_SUBMIT_FAILED } from './types';

function stolenAlertAddSubmitAction(params, identity) {
  return {
    type: STOLEN_ALERT_ADD_SUBMIT,
    params,
    identity,
  };
}

function stolenAlertAddSubmitRequestedAction() {
  return {
    type: STOLEN_ALERT_ADD_SUBMIT_REQUESTED,
  };
}

function stolenAlertAddSubmitSucceededAction(ticketNumber) {
  return {
    type: STOLEN_ALERT_ADD_SUBMIT_SUCCEEDED,
    ticketNumber,
  };
}

function stolenAlertAddSubmitFailedAction(error) {
  return {
    type: STOLEN_ALERT_ADD_SUBMIT_FAILED,
    error,
  };
}

export { stolenAlertAddSubmitAction };
export { stolenAlertAddSubmitRequestedAction };
export { stolenAlertAddSubmitSucceededAction };
export { stolenAlertAddSubmitFailedAction };
