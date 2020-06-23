/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */
import produce, { setAutoFreeze } from 'immer';
import { persistReducer } from 'redux-persist';
import localForage from 'localforage';
import { LOCATION_CHANGE } from 'connected-react-router';
import { STOLEN_ALERT_ADD_SUBMIT, STOLEN_ALERT_ADD_SUBMIT_REQUESTED, STOLEN_ALERT_ADD_SUBMIT_SUCCEEDED, STOLEN_ALERT_ADD_SUBMIT_FAILED } from './types';

const initialState = {
  stolenAlertAddSubmitRequested: false,
  stolenAlertAddSubmitSucceeded: false,
  stolenAlertAddSubmitSucceededTicketNumber: null,
  stolenAlertAddSubmitFailed: false,
};

const persistConfig = {
  key: 'assets.stolenAlert',
  storage: localForage,
  blacklist: ['stolenAlertAddSubmitRequested', 'stolenAlertAddSubmitSucceeded', 'stolenAlertAddSubmitSucceededTicketNumber', 'stolenAlertAddSubmitFailed'],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  switch (action.type) {
    case STOLEN_ALERT_ADD_SUBMIT:
      draft.stolenAlertAddSubmitRequested = false;
      draft.stolenAlertAddSubmitSucceeded = false;
      draft.stolenAlertAddSubmitSucceededTicketNumber = null;
      draft.stolenAlertAddSubmitFailed = false;
      break;

    case STOLEN_ALERT_ADD_SUBMIT_REQUESTED:
      draft.stolenAlertAddSubmitRequested = true;
      break;

    case STOLEN_ALERT_ADD_SUBMIT_SUCCEEDED:
      draft.stolenAlertAddSubmitSucceededTicketNumber = action.ticketNumber;
      draft.stolenAlertAddSubmitSucceeded = true;
      draft.stolenAlertAddSubmitRequested = false;
      break;

    case STOLEN_ALERT_ADD_SUBMIT_FAILED:
      draft.stolenAlertAddSubmitFailed = true;
      draft.stolenAlertAddSubmitRequested = false;
      break;

    case LOCATION_CHANGE:
      draft.stolenAlertAddSubmitRequested = false;
      draft.stolenAlertAddSubmitSucceeded = false;
      draft.stolenAlertAddSubmitSucceededTicketNumber = null;
      draft.stolenAlertAddSubmitFailed = false;
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
