/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */

import { combineReducers } from 'redux';

import assetReturnReducer, { initialState as assetReturnInitialState } from '../modules/asset-return/store/reducers';
import coreReducers, { initialState as coreInitialState } from '../modules/core/store/reducers';
import stolenAlertReducer, { initialState as stolenAlertInitialState } from '../modules/stolen-alerts/store/reducers';
import ticketReducer, { initialState as ticketInitialState } from '../modules/tickets/store/reducers';

// reducers
export const initialState = {
  core: coreInitialState,
  stolenAlert: stolenAlertInitialState,
  ticket: ticketInitialState,
  assetReturn: assetReturnInitialState,
};

export default function createReducer() {
  const rootReducer = combineReducers({
    core: coreReducers,
    stolenAlert: stolenAlertReducer,
    ticket: ticketReducer,
    assetReturn: assetReturnReducer,
  });
  return rootReducer;
}
