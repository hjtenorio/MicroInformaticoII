/* eslint-disable react/prop-types */
/* eslint-disable react/jsx-props-no-spreading */
import React, { Component, useState, useEffect } from 'react';
import { Drawer, Layout } from 'antd';

import SidebarContent from './sidebar-content';

import {
  NAV_STYLE_DRAWER,
  NAV_STYLE_FIXED,
  NAV_STYLE_MINI_SIDEBAR,
  NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR,
  NAV_STYLE_NO_HEADER_MINI_SIDEBAR,
  TAB_SIZE,
  THEME_TYPE_LITE,
  THEME_TYPE_SEMI_DARK,
} from '../theme/constants';

const { Sider } = Layout;

export default function Sidebar({ identity }) {
  const [themeType, setThemeType] = useState(THEME_TYPE_SEMI_DARK);
  const [navCollapsed, toggleCollapsedSideNav] = useState(true);
  const [width, updateWindowWidth] = useState(window.innerWidth);
  const [navStyle, setNavStyle] = useState(NAV_STYLE_FIXED);
  let drawerStyle = 'gx-collapsed-sidebar';

  const { authUser, authMenu, logout } = identity;

  const onToggleCollapsedNav = () => {
    toggleCollapsedSideNav(!navCollapsed);
  };

  const onNavStyleChange = (newNavStyle) => {
    setNavStyle(newNavStyle);
  };

  useEffect(() => {
    window.addEventListener('resize', () => {
      updateWindowWidth(window.innerWidth);
    });
  }, []);

  if (navStyle === NAV_STYLE_FIXED) {
    drawerStyle = '';
  } else if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) {
    drawerStyle = 'gx-mini-sidebar gx-mini-custom-sidebar';
  } else if (navStyle === NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR) {
    drawerStyle = 'gx-custom-sidebar';
  } else if (navStyle === NAV_STYLE_MINI_SIDEBAR) {
    drawerStyle = 'gx-mini-sidebar';
  } else if (navStyle === NAV_STYLE_DRAWER) {
    drawerStyle = 'gx-collapsed-sidebar';
  }
  if (
    (navStyle === NAV_STYLE_FIXED ||
      navStyle === NAV_STYLE_MINI_SIDEBAR ||
      navStyle === NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR) &&
    width < TAB_SIZE
  ) {
    drawerStyle = 'gx-collapsed-sidebar';
  }

  const contentProps = {
    navStyle,
    themeType,
    // pathname,
    width,
    navCollapsed,
    toggleCollapsedSideNav,
    onNavStyleChange,
    setNavStyle,
    logout,
    authMenu,
    authUser,
  };

  return (
    <Sider
      className={`gx-app-sidebar ${drawerStyle} ${
        themeType !== THEME_TYPE_LITE ? 'gx-layout-sider-dark' : null
      }`}
      trigger={null}
      collapsed={
        width < TAB_SIZE
          ? false
          : navStyle === NAV_STYLE_MINI_SIDEBAR ||
            navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR
      }
      theme={themeType === THEME_TYPE_LITE ? 'lite' : 'dark'}
      collapsible
    >
      {navStyle === NAV_STYLE_DRAWER || width < TAB_SIZE ? (
        <Drawer
          wrapClassName={`gx-drawer-sidebar ${
            themeType !== THEME_TYPE_LITE ? 'gx-drawer-sidebar-dark' : null
          }`}
          placement="left"
          closable={false}
          onClose={onToggleCollapsedNav}
          visible={navCollapsed}
        >
          <SidebarContent {...contentProps} />
        </Drawer>
      ) : (
        <SidebarContent {...contentProps} />
      )}
    </Sider>
  );
}
