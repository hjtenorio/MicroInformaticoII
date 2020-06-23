import { combineReducers } from 'redux';
import Settings from './Settings';

const reducers = combineReducers({
  // routing: routerReducer,
  settings: Settings,
  // auth: Auth,
  // notes: Notes,
  // contact: Contact,
  // common: Common,
});

export default reducers;
