import { push } from 'connected-react-router';
import moment from 'moment';
import React, { createContext, useContext } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';

import { notification } from '@valtx-mi2/ui';

import * as actions from '../../../../../store/actions';
import * as selectors from '../../../../../store/selectors';

const applicationUIContext = createContext();

// eslint-disable-next-line react/prop-types
export function ApplicationUIProvider({ children }) {
  // eslint-disable-next-line no-use-before-define
  const applicationUI = useApplicationUIProvider();

  return (
    <applicationUIContext.Provider value={applicationUI}>
      {children}
    </applicationUIContext.Provider>
  );
}

export function useApplicationUI() {
  return useContext(applicationUIContext);
}

const {
  makeSidebarCollapsedSelector,
  makeNavStyleSelector,
  makeThemeTypeSelector,
  makeWidthSelector,
  makeCurrentMenuSelector,
} = selectors;

function useApplicationUIProvider() {
  const dispatch = useDispatch();

  const {
    windowsResizedAction,
    toggleSidebarCollapsedAction,
    setNavStyleAction,
    setCurrentMenuAction,
  } = actions;

  const {
    sidebarCollapsed,
    navStyle,
    themeType,
    width,
    currentMenu,
  } = useSelector(
    createStructuredSelector({
      sidebarCollapsed: makeSidebarCollapsedSelector(),
      navStyle: makeNavStyleSelector(),
      themeType: makeThemeTypeSelector(),
      width: makeWidthSelector(),
      currentMenu: makeCurrentMenuSelector(),
    })
  );

  function onWindowsResized() {
    dispatch(windowsResizedAction());
  }

  function onToggleSidebarCollapsed() {
    dispatch(toggleSidebarCollapsedAction());
  }

  function onSetNavStyle(newNavStyle) {
    dispatch(setNavStyleAction(newNavStyle));
  }

  function onSetCurrentMenu(newCurrentMenu) {
    dispatch(setCurrentMenuAction(newCurrentMenu));
  }

  return {
    sidebarCollapsed,
    navStyle,
    themeType,
    width,
    currentMenu,
    onWindowsResized,
    onToggleSidebarCollapsed,
    onSetNavStyle,
    onSetCurrentMenu,
  };
}

// const identityContext = createContext();

// export function IdentityProvider({ children }) {
//   const identity = useIdentityProvider();

//   return (
//     <identityContext.Provider value={identity}>
//       {children}
//     </identityContext.Provider>
//   );
// }

// export const useIdentity = () => {
//   return useContext(identityContext);
// };

// const {
//   makeUserSelector,
//   makeTokenSelector,
//   makeIsAuthenticatedSelector,
//   makeMenuSelector,
//   makeSessionStartSelector,
// } = selectors;

// const { userLogoutAction } = actions;

// function useIdentityProvider() {
//   const { user, token, menu, isAuthenticated, sessionStart } = useSelector(
//     createStructuredSelector({
//       user: makeUserSelector(),
//       token: makeTokenSelector(),
//       menu: makeMenuSelector(),
//       isAuthenticated: makeIsAuthenticatedSelector(),
//       sessionStart: makeSessionStartSelector(),
//     })
//   );

//   const dispatch = useDispatch();

//   function reset() {
//     dispatch(userLogoutAction());
//   }

//   function logout() {
//     dispatch(userLogoutAction());
//     dispatch(push('/identity/login'));
//   }

//   try {
//     if (!(sessionStart instanceof moment)) {
//       throw new Error('session start not defined');
//     }
//     if (!token) {
//       throw new Error('token not defined');
//     }
//     // eslint-disable-next-line camelcase
//     const { expires_in } = token;
//     // eslint-disable-next-line camelcase
//     if (!expires_in) {
//       throw new Error('expires_in not defined');
//     }
//     const now = moment();
//     // eslint-disable-next-line camelcase
//     const isTokenValid = now.diff(sessionStart, 'seconds') < expires_in;

//     if (!isTokenValid) {
//       notification.warning({
//         message: 'Sesion Expirada',
//         description:
//           'Su sesion ha expirado, por favor vuelva a iniciar sesion.',
//         placement: 'bottomRight',
//       });
//       dispatch(push('/identity/login'));
//     }
//   } catch (e) {
//     // statements to handle any exceptions
//     console.log(e); // pass exception object to error handler
//     dispatch(push('/identity/login'));
//   }

//   return {
//     user,
//     token,
//     menu,
//     isAuthenticated,
//     logout,
//     reset,
//     sessionStart,
//   };
// }
