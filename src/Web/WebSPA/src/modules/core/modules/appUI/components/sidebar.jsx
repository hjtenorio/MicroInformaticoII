/* eslint-disable react/jsx-props-no-spreading */
/* eslint-disable no-nested-ternary */
/* eslint-disable jsx-a11y/no-static-element-interactions */
/* eslint-disable jsx-a11y/click-events-have-key-events */

import { push } from 'connected-react-router';
import React, { useEffect, useState } from 'react';
import { useDispatch } from 'react-redux';
import { Link } from 'react-router-dom';

import { useIdentity } from '@valtx-mi2/identity';
import {
  CustomScrollbars,
  Drawer,
  Menu,
  Sider,
  SiderHeader,
  Theme,
  UserProfile,
  ValtxLogo,
} from '@valtx-mi2/ui';

import { useApplicationUI } from '../hooks/useApplicationUI';

const {
  NAV_STYLE_FIXED,
  THEME_TYPE_SEMI_DARK,
  NAV_STYLE_NO_HEADER_MINI_SIDEBAR,
  NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR,
  NAV_STYLE_MINI_SIDEBAR,
  THEME_TYPE_LITE,
  NAV_STYLE_DRAWER,
  TAB_SIZE,
} = Theme.constants;

function Sidebar(props) {
  const identity = useIdentity();

  const applicationUI = useApplicationUI();

  const { sidebarCollapsed, onToggleSidebarCollapsed } = applicationUI;
  const { navStyle, onSetNavStyle } = applicationUI;
  const { themeType } = applicationUI;
  const { width, onWindowsResized } = applicationUI;
  const { currentMenu, onSetCurrentMenu } = applicationUI;

  useEffect(() => {
    window.addEventListener('resize', () => {
      onWindowsResized();
    });
  }, []);

  if (!identity) {
    console.log('Identity not found');
    return null;
  }

  if (!identity.isAuthenticated) {
    return null;
  }

  const { user, menu, logout } = identity;
  const MenuItemGroup = Menu.ItemGroup;

  const getNoHeaderClass = (currentNavStyle) => {
    if (
      currentNavStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR ||
      currentNavStyle === NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR
    ) {
      return 'gx-no-header-notifications';
    }
    return '';
  };

  function SidebarContent() {
    return (
      <>
        <SiderHeader>
          {navStyle === NAV_STYLE_FIXED ||
          navStyle === NAV_STYLE_MINI_SIDEBAR ? (
            <div className="gx-linebar">
              <i
                className={`gx-icon-btn icon icon-${
                  navStyle === NAV_STYLE_MINI_SIDEBAR
                    ? 'menu-unfold'
                    : 'menu-fold'
                } ${themeType !== THEME_TYPE_LITE ? 'gx-text-white' : ''}`}
                onClick={() => {
                  if (navStyle === NAV_STYLE_DRAWER) {
                    onToggleSidebarCollapsed();
                  } else if (navStyle === NAV_STYLE_FIXED) {
                    onSetNavStyle(NAV_STYLE_MINI_SIDEBAR);
                  } else if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) {
                    onToggleSidebarCollapsed();
                  } else {
                    onSetNavStyle(NAV_STYLE_FIXED);
                  }
                }}
              />
            </div>
          ) : null}
          <Link to="/" className="gx-site-logo">
            {navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR &&
            width >= TAB_SIZE ? (
              <div css={{ display: 'flex', maxWidth: '80px' }}>
                <ValtxLogo type="white" />
              </div>
            ) : themeType === THEME_TYPE_LITE ? (
              <div css={{ display: 'flex', maxWidth: '80px' }}>
                <ValtxLogo type="white" />
              </div>
            ) : (
              <div css={{ display: 'flex', maxWidth: '80px' }}>
                <ValtxLogo type="white" />
              </div>
            )}
          </Link>
        </SiderHeader>

        <div className="gx-sidebar-content">
          <div className="gx-sidebar-notifications" css={{ display: 'block' }}>
            <UserProfile user={user} logout={logout} />
          </div>
          <CustomScrollbars className="gx-layout-sider-scrollbar">
            <Menu
              onClick={(e) => onSetCurrentMenu(e.key)}
              selectedKeys={[currentMenu]}
              theme="dark"
              mode="inline"
              inlineIndent="10"
            >
              {menu &&
                menu.map((menuItem) => (
                  <MenuItemGroup
                    key={menuItem.id}
                    className="gx-menu-group"
                    title={<span> {menuItem.title}</span>}
                  >
                    {menuItem.children &&
                      menuItem.children.map((submenu) => (
                        <Menu.Item key={submenu.key}>
                          <Link to={`${submenu.url}`}>
                            <i className={`icon ${submenu.iconTooltip}`} />
                            <span>{submenu.title}</span>
                          </Link>
                        </Menu.Item>
                      ))}
                  </MenuItemGroup>
                ))}
            </Menu>
          </CustomScrollbars>
        </div>
      </>
    );
  }

  return (
    <Sider
      trigger={null}
      collapsible
      collapsed={
        width < TAB_SIZE
          ? false
          : navStyle === NAV_STYLE_MINI_SIDEBAR ||
            navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR
      }
      {...props}
    >
      {navStyle === NAV_STYLE_DRAWER || width < TAB_SIZE ? (
        <Drawer
          wrapClassName={`gx-drawer-sidebar ${
            themeType !== THEME_TYPE_LITE ? 'gx-drawer-sidebar-dark' : null
          }`}
          placement="left"
          closable={false}
          onClose={onToggleSidebarCollapsed}
          visible={!sidebarCollapsed}
        >
          <SidebarContent />
        </Drawer>
      ) : (
        <SidebarContent />
      )}
    </Sider>
  );
}

export default Sidebar;
