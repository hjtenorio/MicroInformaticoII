/* eslint-disable no-use-before-define */
/* eslint-disable react/prop-types */

import { push } from 'connected-react-router';
import moment from 'moment';
import React, { createContext, useContext } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';

import { notification } from '@valtx-mi2/ui';

import * as actions from '../../../store/actions';
import * as selectors from '../../../store/selectors';

export const IdentityContext = createContext();

export function IdentityProvider({ children }) {
  return (
    <IdentityContext.Provider value={useIdentityProvider()}>
      {children}
    </IdentityContext.Provider>
  );
}

export const useIdentity = () => {
  return useContext(IdentityContext);
};

const {
  makeUserSelector,
  makeTokenSelector,
  makeIsAuthenticatedSelector,
  makeMenuSelector,
  makeSessionStartSelector,
} = selectors;

const { userLogoutAction } = actions;

function useIdentityProvider() {
  const { user, token, menu, isAuthenticated, sessionStart } = useSelector(
    createStructuredSelector({
      user: makeUserSelector(),
      token: makeTokenSelector(),
      menu: makeMenuSelector(),
      isAuthenticated: makeIsAuthenticatedSelector(),
      sessionStart: makeSessionStartSelector(),
    })
  );

  const dispatch = useDispatch();

  function reset() {
    dispatch(userLogoutAction());
  }

  function logout() {
    dispatch(userLogoutAction());
    dispatch(push('/identity/login'));
  }

  // try {
  //   if (!(sessionStart instanceof moment)) {
  //     throw new Error('session start not defined');
  //   }
  //   if (!token) {
  //     throw new Error('token not defined');
  //   }
  //   // eslint-disable-next-line camelcase
  //   const { expires_in } = token;
  //   // eslint-disable-next-line camelcase
  //   if (!expires_in) {
  //     throw new Error('expires_in not defined');
  //   }
  //   const now = moment();
  //   // eslint-disable-next-line camelcase
  //   const isTokenValid = now.diff(sessionStart, 'seconds') < expires_in;

  //   if (!isTokenValid) {
  //     notification.warning({
  //       message: 'Sesion Expirada',
  //       description:
  //         'Su sesion ha expirado, por favor vuelva a iniciar sesion.',
  //       placement: 'bottomRight',
  //     });
  //     dispatch(push('/identity/login'));
  //   }
  // } catch (e) {
  //   // statements to handle any exceptions
  //   console.log(e); // pass exception object to error handler
  //   dispatch(push('/identity/login'));
  // }

  return {
    user,
    token,
    menu,
    isAuthenticated,
    logout,
    reset,
    sessionStart,
  };
}
