import { createSelector } from 'reselect';

import { initialState } from './reducers';

const appUIState = (state) => state.core.appUI || initialState;

const makeSidebarCollapsedSelector = () => createSelector(appUIState, (state) => state.sidebarCollapsed);
const makeNavStyleSelector = () => createSelector(appUIState, (state) => state.navStyle);
const makeThemeTypeSelector = () => createSelector(appUIState, (state) => state.themeType);
const makeWidthSelector = () => createSelector(appUIState, (state) => state.width);
const makeCurrentMenuSelector = () => createSelector(appUIState, (state) => state.currentMenu);

export { makeSidebarCollapsedSelector, makeNavStyleSelector, makeThemeTypeSelector, makeWidthSelector, makeCurrentMenuSelector };
