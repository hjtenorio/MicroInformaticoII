// .storybook/decorators.js

import withReduxCore from 'addon-redux/withRedux';
import React from 'react';
import { Provider } from 'react-redux';

import addons from '@storybook/addons';

import configureStore, { initialState } from '../src/store';

const { store, persistor } = configureStore(initialState);

export const withRedux = (state, actions) =>
  withReduxCore(addons)({
    Provider,
    store,
    state,
    actions,
  });
