/* eslint-disable no-param-reassign */

import { connectRouter } from 'connected-react-router';
import { combineReducers } from 'redux';

import { initialState as assetsInitialState, createReducer as createAssetsReducer } from '@valtx-mi2/assets';
import { initialState as coreInitialState, createReducer as createCoreReducers } from '@valtx-mi2/core';
import { createReducer as createIdentityReducer, initialState as identityInitialState } from '@valtx-mi2/identity';

import history from '../utils/history';

export const initialState = {
  core: coreInitialState,
  identity: identityInitialState,
  assets: assetsInitialState,
};

const identityReducer = createIdentityReducer();
const assetsReducer = createAssetsReducer();
const coreReducers = createCoreReducers();

export default function createReducer() {
  const rootReducer = combineReducers({
    core: coreReducers,
    identity: identityReducer,
    assets: assetsReducer,
    router: connectRouter(history),
  });
  return rootReducer;
}
