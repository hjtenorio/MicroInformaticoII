import { SET_CURRENT_MENU, SET_NAV_STYLE, TOGGLE_SIDEBAR_COLLAPSED, WINDOWS_RESIZED } from './types';

function windowsResizedAction() {
  return {
    type: WINDOWS_RESIZED,
  };
}

function toggleSidebarCollapsedAction() {
  return {
    type: TOGGLE_SIDEBAR_COLLAPSED,
  };
}

function setNavStyleAction(navStyle) {
  return {
    type: SET_NAV_STYLE,
    navStyle,
  };
}

function setCurrentMenuAction(currentMenu) {
  return {
    type: SET_CURRENT_MENU,
    currentMenu,
  };
}

export { windowsResizedAction };
export { toggleSidebarCollapsedAction };
export { setNavStyleAction };
export { setCurrentMenuAction };
