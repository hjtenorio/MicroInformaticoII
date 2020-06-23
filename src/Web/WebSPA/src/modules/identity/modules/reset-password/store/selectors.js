import { createSelector } from 'reselect';
import { initialState } from './reducer';

const resetPasswordState = (state) =>
  state.identity.resetPassword || initialState;

const makeResetPasswordRequestedSelector = () =>
  createSelector(resetPasswordState, (state) => state.resetPasswordRequested);

const makeResetPasswordSucceededSelector = () =>
  createSelector(resetPasswordState, (state) => state.resetPasswordSucceeded);

const makeResetPasswordFailedSelector = () =>
  createSelector(resetPasswordState, (state) => state.resetPasswordFailed);

const makeResetPasswordFailedErrorSelector = () =>
  createSelector(resetPasswordState, (state) => state.resetPasswordFailedError);

export default resetPasswordState;

export {
  makeResetPasswordRequestedSelector,
  makeResetPasswordSucceededSelector,
  makeResetPasswordFailedSelector,
  makeResetPasswordFailedErrorSelector,
};
