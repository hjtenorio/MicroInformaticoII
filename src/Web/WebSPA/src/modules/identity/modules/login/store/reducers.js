/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */

import { LOCATION_CHANGE } from 'connected-react-router';
import produce, { setAutoFreeze } from 'immer';
import localForage from 'localforage';
import moment from 'moment';
import { persistReducer } from 'redux-persist';

import { USER_LOGIN, USER_LOGIN_FAILED, USER_LOGIN_REQUESTED, USER_LOGIN_SUCCEEDED, USER_LOGOUT } from './types';

const initialState = {
  userLoginRequested: false,
  userLoginSucceeded: false,
  userLoginFailed: false,
  userLoginFailedError: '',
  user: null,
  token: null,
  menu: null,
  isAuthenticated: false,
  sessionStart: null,
};

const persistConfig = {
  key: 'identity.login',
  storage: localForage,
  // blacklist: ['userLoginRequested', 'userLoginSucceeded', 'userLoginFailed', 'userLoginFailedError', 'user', 'token', 'menu', 'isAuthenticated'],
  blacklist: ['userLoginRequested', 'userLoginSucceeded', 'userLoginFailed', 'userLoginFailedError'],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  switch (action.type) {
    case USER_LOGIN:
      draft.userLoginRequested = false;
      draft.userLoginSucceeded = false;
      draft.userLoginFailed = false;
      draft.userLoginFailedError = '';
      draft.user = null;
      draft.token = null;
      draft.menu = null;
      draft.isAuthenticated = false;
      draft.sessionStart = null;
      break;

    case USER_LOGIN_REQUESTED:
      draft.userLoginRequested = true;
      break;

    case USER_LOGIN_SUCCEEDED:
      draft.user = action.user;
      draft.token = action.token;
      draft.menu = action.menu;
      draft.isAuthenticated = true;
      draft.userLoginSucceeded = true;
      draft.sessionStart = moment();
      break;

    case USER_LOGIN_FAILED:
      draft.userLoginFailedErrorMessage = action.error;
      draft.userLoginRequested = false;
      draft.userLoginFailed = true;
      break;
    case USER_LOGOUT:
      draft.user = [];
      draft.token = null;
      draft.menu = null;
      draft.isAuthenticated = false;
      draft.userLoginRequested = false;
      draft.userLoginSucceeded = false;
      draft.userLoginFailed = false;
      draft.userLoginFailedError = '';
      draft.sessionStart = null;
      break;

    case LOCATION_CHANGE:
      draft.userLoginRequested = false;
      draft.userLoginSucceeded = false;
      draft.userLoginFailed = false;
      draft.userLoginFailedError = '';
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
