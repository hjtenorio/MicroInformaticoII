import withReduxEnhancer from 'addon-redux/enhancer';
import { routerMiddleware } from 'connected-react-router';
import { applyMiddleware, compose, createStore } from 'redux';
import { persistStore } from 'redux-persist';
import createSagaMiddleware from 'redux-saga';

import history from '../utils/history';
import createReducer from './reducers';
import rootSaga from './sagas';

// import rootSaga from '../services/identity/features/forgot-password/store/sagas';

const routeMiddleware = routerMiddleware(history);
const sagaMiddleware = createSagaMiddleware();

const composeEnhancers = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

export default function configureStore(initialState = {}) {
  const createMiddlewareEnhancer = () => {
    const middleware = [];
    if (process.env.NODE_ENV !== 'production') {
      // include other middlewares as needed, like the invariant and logger middlewares
    }
    middleware.push(sagaMiddleware);
    middleware.push(routeMiddleware);
    return applyMiddleware(...middleware);
  };

  const createEnhancer = () => {
    const enhancers = [];
    enhancers.push(createMiddlewareEnhancer());
    if (process.env.NODE_ENV !== 'production') {
      enhancers.push(withReduxEnhancer);
    }
    return compose(...enhancers);
  };

  // const enhancers = [applyMiddleware(...middlewares)];

  const store = createStore(createReducer(), initialState, composeEnhancers(createEnhancer()));

  sagaMiddleware.run(rootSaga);
  // store.injectedReducers = {};
  // store.injectedSagas = {};

  // Make reducers hot reloadable, see http://mxs.is/googmo
  // if (module.hot) {
  //   module.hot.accept('./reducer', () => {
  //     store.replaceReducer(createReducer(store.injectedReducers));
  //   });
  // }

  const persistorConfig = {
    key: 'micro2',
  };

  const persistor = persistStore(store, persistorConfig);
  return { store, persistor };
}
