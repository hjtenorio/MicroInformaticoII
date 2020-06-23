/* eslint-disable no-param-reassign */

import produce, { setAutoFreeze } from 'immer';
import localForage from 'localforage';
import { persistReducer } from 'redux-persist';

import { Theme } from '@valtx-mi2/ui';

import { SET_CURRENT_MENU, SET_NAV_STYLE, TOGGLE_SIDEBAR_COLLAPSED, WINDOWS_RESIZED } from './types';

const { NAV_STYLE_FIXED, THEME_TYPE_SEMI_DARK } = Theme.constants;

const initialState = {
  sidebarCollapsed: true,
  navStyle: NAV_STYLE_FIXED,
  themeType: THEME_TYPE_SEMI_DARK,
  width: window.innerWidth,
  currentMenu: [],
};

const persistConfig = {
  key: 'core.appUI',
  storage: localForage,
  blacklist: ['currentMenu', 'width'],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  // eslint-disable-next-line default-case
  switch (action.type) {
    case WINDOWS_RESIZED:
      draft.width = window.innerWidth;
      break;

    case TOGGLE_SIDEBAR_COLLAPSED:
      draft.sidebarCollapsed = !draft.sidebarCollapsed;
      break;

    case SET_NAV_STYLE:
      draft.navStyle = action.navStyle;
      break;

    case SET_CURRENT_MENU:
      draft.currentMenu = action.currentMenu;
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
