import { createSelector } from 'reselect';

import { initialState } from './reducer';

const identityState = (state) => state.identity.forgotPassword || initialState;

const makeForgotPasswordRequestedSelector = () =>
  createSelector(identityState, (state) => {
    return state.forgotPasswordRequested;
  });

const makeForgotPasswordSucceededSelector = () => createSelector(identityState, (state) => state.forgotPasswordSucceeded);

const makeForgotPasswordFailedSelector = () => createSelector(identityState, (state) => state.forgotPasswordFailed);

const makeForgotPasswordFailedErrorSelector = () => createSelector(identityState, (state) => state.forgotPasswordFailedError);

export default identityState;

export { makeForgotPasswordRequestedSelector, makeForgotPasswordSucceededSelector, makeForgotPasswordFailedSelector, makeForgotPasswordFailedErrorSelector };
