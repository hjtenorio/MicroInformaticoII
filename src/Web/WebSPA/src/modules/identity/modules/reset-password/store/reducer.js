/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */
import produce, { setAutoFreeze } from 'immer';
import { persistReducer } from 'redux-persist';
import localForage from 'localforage';
import { LOCATION_CHANGE } from 'connected-react-router';
import { RESET_PASSWORD_REQUESTED, RESET_PASSWORD_SUCCEEDED, RESET_PASSWORD_FAILED } from './types';

const initialState = {
  resetPasswordRequested: false,
  resetPasswordSucceeded: false,
  resetPasswordFailed: false,
  resetPasswordFailedError: '',
};

const persistConfig = {
  key: 'identity.resetPassword',
  storage: localForage,
  blacklist: ['resetPasswordRequested', 'resetPasswordSucceeded', 'resetPasswordFailed', 'resetPasswordFailedError'],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  switch (action.type) {
    case RESET_PASSWORD_REQUESTED:
      draft.resetPasswordSucceeded = false;
      draft.resetPasswordFailed = false;
      draft.resetPasswordFailedError = '';
      draft.resetPasswordRequested = true;
      break;

    case RESET_PASSWORD_SUCCEEDED:
      draft.resetPasswordRequested = false;
      draft.resetPasswordFailed = false;
      draft.resetPasswordFailedError = '';
      draft.resetPasswordSucceeded = true;
      break;

    case RESET_PASSWORD_FAILED:
      draft.resetPasswordRequested = false;
      draft.resetPasswordSucceeded = false;
      draft.resetPasswordFailed = true;
      draft.resetPasswordFailedError = action.error.response.data.message;
      break;

    case LOCATION_CHANGE:
      draft.resetPasswordRequested = false;
      draft.resetPasswordSucceeded = false;
      draft.resetPasswordFailed = false;
      draft.resetPasswordFailedError = '';
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
