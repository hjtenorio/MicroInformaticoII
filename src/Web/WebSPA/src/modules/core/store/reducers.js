/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */

import { combineReducers } from 'redux';

import appUIReducers, { initialState as appUIInitialState } from '../modules/appUI/store/reducers';

// reducers
export const initialState = {
  appUI: appUIInitialState,
};

export default function createReducer() {
  const rootReducer = combineReducers({
    appUI: appUIReducers,
  });
  return rootReducer;
}
