/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */
import produce, { setAutoFreeze } from 'immer';
import { persistReducer } from 'redux-persist';
import localForage from 'localforage';
import { LOCATION_CHANGE } from 'connected-react-router';
import { FORGOT_PASSWORD_REQUESTED, FORGOT_PASSWORD_SUCCEEDED, FORGOT_PASSWORD_FAILED } from './types';

const initialState = {
  forgotPasswordRequested: false,
  forgotPasswordSucceeded: false,
  forgotPasswordFailed: false,
  forgotPasswordFailedError: null,
};

const persistConfig = {
  key: 'identity.forgotPassword',
  storage: localForage,
  blacklist: ['forgotPasswordRequested', 'forgotPasswordSucceeded', 'forgotPasswordFailed', 'forgotPasswordFailedError'],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  switch (action.type) {
    case FORGOT_PASSWORD_REQUESTED:
      draft.forgotPasswordRequested = true;
      draft.forgotPasswordSucceeded = false;
      draft.forgotPasswordFailed = false;
      draft.forgotPasswordFailedError = null;
      break;

    case FORGOT_PASSWORD_SUCCEEDED:
      draft.forgotPasswordRequested = false;
      draft.forgotPasswordSucceeded = true;
      draft.forgotPasswordFailed = false;
      draft.forgotPasswordFailedError = null;
      break;

    case FORGOT_PASSWORD_FAILED:
      draft.forgotPasswordRequested = false;
      draft.forgotPasswordSucceeded = false;
      draft.forgotPasswordFailed = true;
      const { status } = action.error.response;
      switch (status) {
        case 500:
          draft.forgotPasswordFailedError = action.error.message;
          break;

        case 404:
          draft.forgotPasswordFailedError = action.error.response.data;
          break;

        default:
          draft.forgotPasswordFailedError = 'Error desconocido';
          break;
      }
      break;
    case LOCATION_CHANGE:
      draft.forgotPasswordRequested = false;
      draft.forgotPasswordSucceeded = false;
      draft.forgotPasswordFailed = false;
      draft.forgotPasswordFailedError = null;
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
