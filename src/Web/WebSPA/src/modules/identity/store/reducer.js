import { combineReducers } from 'redux';

import forgotPasswordReducer, { initialState as forgotPasswordInitialState } from '../modules/forgot-password/store/reducer';
import loginReducer, { initialState as loginInitialState } from '../modules/login/store/reducers';
import resetPasswordReducer, { initialState as resetPasswordInitialState } from '../modules/reset-password/store/reducer';

export const initialState = {
  login: loginInitialState,
  forgotPassword: forgotPasswordInitialState,
  resetPassword: resetPasswordInitialState,
};

export default function createReducer() {
  const rootReducer = combineReducers({
    login: loginReducer,
    forgotPassword: forgotPasswordReducer,
    resetPassword: resetPasswordReducer,
  });
  return rootReducer;
}
