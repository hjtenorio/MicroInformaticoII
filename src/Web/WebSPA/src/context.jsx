/* eslint-disable react/prop-types */

import { ConnectedRouter } from 'connected-react-router';
import React from 'react';
import { Provider } from 'react-redux';
import { PersistGate } from 'redux-persist/integration/react';

import { IdentityProvider } from '@valtx-mi2/identity';

import { ApplicationUIProvider } from './modules/core/modules/appUI/hooks/useApplicationUI';
import configureStore, { initialState } from './store';
import history from './utils/history';

const { store, persistor } = configureStore(initialState);

export default function Micro2Context({ children }) {
  return (
    <Provider store={store}>
      <PersistGate loading={null} persistor={persistor}>
        <ConnectedRouter history={history}>
          <IdentityProvider>
            <ApplicationUIProvider>{children}</ApplicationUIProvider>
          </IdentityProvider>
        </ConnectedRouter>
      </PersistGate>
    </Provider>
  );
}
