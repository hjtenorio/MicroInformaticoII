/* eslint-disable import/prefer-default-export */
/* eslint-disable react/prop-types */
/* eslint-disable react/jsx-props-no-spreading */

import moment from 'moment';
import React from 'react';
import { Route as BaseRoute, Redirect } from 'react-router-dom';

import { useIdentity } from '@valtx-mi2/identity';
import { notification } from '@valtx-mi2/ui';

const Route = ({ component: Component, secured, ...rest }) => {
  const identity = useIdentity();

  if (!secured) {
    return <BaseRoute {...rest} component={Component} />;
  }

  const isAuthenticated = identity ? identity.isAuthenticated : false;
  // function isAuthenticated() {
  //   if (!identity || !identity.isAuthenticated) {
  //     return false;
  //   }
  //   try {
  //     const { sessionStart, token } = identity;
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
  //       identity.reset();
  //     }
  //     return true;
  //   } catch (e) {
  //     // statements to handle any exceptions
  //     console.log(e); // pass exception object to error handler
  //     identity.reset();
  //     return false;
  //   }
  // }

  return (
    <BaseRoute
      {...rest}
      render={(props) =>
        isAuthenticated ? (
          <Component identity={identity} {...props} />
        ) : (
          <Redirect
            to={{
              pathname: '/identity/login',
            }}
          />
        )
      }
    />
  );
};

export default Route;
