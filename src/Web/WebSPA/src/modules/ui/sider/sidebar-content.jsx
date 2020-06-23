/* eslint-disable no-unused-vars */
/* eslint-disable no-nested-ternary */
/* eslint-disable jsx-a11y/no-static-element-interactions */
/* eslint-disable jsx-a11y/click-events-have-key-events */
/* eslint-disable react/prop-types */
import React, { useState } from 'react';
import { Menu } from 'antd';
import { Link } from 'react-router-dom';
import IntlMessages from 'intl/intl-messages';
import CustomScrollbars from '../custom-scrollbars';
import Auxiliary from './auxiliary';
import UserProfile from '../user-profile';
// import AppsNavigation from './AppsNavigation';
import ValtxLogo from '../valtx-logo/index';
import {
  NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR,
  NAV_STYLE_NO_HEADER_MINI_SIDEBAR,
  THEME_TYPE_LITE,
  NAV_STYLE_DRAWER,
  NAV_STYLE_FIXED,
  NAV_STYLE_MINI_SIDEBAR,
  TAB_SIZE,
} from '../theme/constants';

const { SubMenu } = Menu;
const MenuItemGroup = Menu.ItemGroup;

export default function SidebarContent({
  navStyle,
  themeType,
  pathname,
  width,
  navCollapsed,
  onToggleCollapsedSideNav,
  onNavStyleChange,
  setNavStyle,
  logout,
  authMenu,
  authUser,
}) {
  // eslint-disable-next-line no-unused-vars
  // eslint-disable-next-line no-shadow
  const getNoHeaderClass = (navStyle) => {
    if (
      navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR ||
      navStyle === NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR
    ) {
      return 'gx-no-header-notifications';
    }
    return '';
  };
  // eslint-disable-next-line no-shadow
  const getNavStyleSubMenuClass = (navStyle) => {
    if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) {
      return 'gx-no-header-submenu-popup';
    }
    return '';
  };

  const [currentMenu, setCurrentMenu] = useState([]);

  if (width < TAB_SIZE && navStyle === NAV_STYLE_FIXED) {
    setNavStyle(NAV_STYLE_DRAWER);
  }

  const menuClick = (e) => setCurrentMenu(e.key);
  return (
    <Auxiliary>
      <div className="gx-layout-sider-header">
        {navStyle === NAV_STYLE_FIXED || navStyle === NAV_STYLE_MINI_SIDEBAR ? (
          <div className="gx-linebar">
            <i
              className={`gx-icon-btn icon icon-${
                navStyle === NAV_STYLE_MINI_SIDEBAR
                  ? 'menu-unfold'
                  : 'menu-fold'
              } ${themeType !== THEME_TYPE_LITE ? 'gx-text-white' : ''}`}
              onClick={() => {
                if (navStyle === NAV_STYLE_DRAWER) {
                  onToggleCollapsedSideNav();
                } else if (navStyle === NAV_STYLE_FIXED) {
                  onNavStyleChange(NAV_STYLE_MINI_SIDEBAR);
                } else if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) {
                  onToggleCollapsedSideNav();
                } else {
                  onNavStyleChange(NAV_STYLE_FIXED);
                }
              }}
            />
          </div>
        ) : null}

        <Link to="/" className="gx-site-logo">
          {/* {navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR &&
          width >= TAB_SIZE ? (
            <img alt="" src={require('assets/images/w-logo.png')} />
          ) : themeType === THEME_TYPE_LITE ? (
            <img alt="" src={require('assets/images/logo-white.png')} />
          ) : (
            <img alt="" src={require('assets/images/logo.png')} />
          )} */}

          <div css={{ maxWidth: '85px' }}>
            <ValtxLogo type="white" />
          </div>
        </Link>
      </div>
      <div className="gx-sidebar-content">
        <div
          className={`gx-sidebar-notifications ${getNoHeaderClass(navStyle)}`}
        >
          <UserProfile user={authUser} logout={logout} />
          {/* <AppsNavigation /> */}
        </div>
        <CustomScrollbars className="gx-layout-sider-scrollbar">
          <Menu
            onClick={menuClick}
            selectedKeys={[currentMenu]}
            theme="dark"
            mode="inline"
            inlineIndent="10"
          >
            {authMenu &&
              authMenu.map((menu) => (
                <MenuItemGroup
                  key={menu.key}
                  className="gx-menu-group"
                  title={<span> {menu.title}</span>}
                >
                  {menu.children.map((submenu) => (
                    <Menu.Item key={submenu.key}>
                      <Link to={`/${submenu.url}`}>
                        <i className="icon icon-crm" />
                        {submenu.title}
                      </Link>
                    </Menu.Item>
                  ))}
                </MenuItemGroup>
              ))}
          </Menu>
        </CustomScrollbars>
      </div>
    </Auxiliary>
  );
}
