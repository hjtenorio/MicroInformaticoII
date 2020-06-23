import { createSelector } from 'reselect';

import { initialState } from './reducers';

const identityState = (state) => state.identity.login || initialState;

const makeUserLoginRequestedSelector = () => createSelector(identityState, (state) => state.userLoginRequested);

const makeUserLoginSucceededSelector = () => createSelector(identityState, (state) => state.userLoginSucceeded);

const makeUserLoginFailedSelector = () => createSelector(identityState, (state) => state.userLoginFailed);

const makeUserLoginFailedErrorSelector = () => createSelector(identityState, (state) => state.userLoginFailedError);

const makeUserLoginFailedErrorMessageSelector = () => createSelector(identityState, (state) => state.userLoginFailedErrorMessage);

const makeUserSelector = () => createSelector(identityState, (state) => state.user);

const makeTokenSelector = () => createSelector(identityState, (state) => state.token);

const makeMenuSelector = () => createSelector(identityState, (state) => state.menu);

const makeIsAuthenticatedSelector = () => createSelector(identityState, (state) => state.isAuthenticated);

const makeSessionStartSelector = () => createSelector(identityState, (state) => state.sessionStart);

export default identityState;

export {
  makeUserLoginRequestedSelector,
  makeUserLoginSucceededSelector,
  makeUserLoginFailedSelector,
  makeUserLoginFailedErrorSelector,
  makeUserLoginFailedErrorMessageSelector,
  makeUserSelector,
  makeTokenSelector,
  makeMenuSelector,
  makeIsAuthenticatedSelector,
  makeSessionStartSelector,
};
