/* eslint-disable jsx-a11y/no-static-element-interactions */
/* eslint-disable jsx-a11y/click-events-have-key-events */
/* eslint-disable react/prop-types */

import React, { useState, useEffect } from 'react';
import { Drawer, Layout } from 'antd';

const { Sider } = Layout;

const TAB_SIZE = 992;

function Sidebar({ children }) {
  const [collapsed, setCollapsed] = useState(null);
  const [width, setWidth] = useState(window.innerWidth);

  const SidebarContent =
    width < TAB_SIZE ? (
      <Drawer
        wrapClassName="gx-drawer-sidebar gx-drawer-sidebar-dark"
        placement="left"
        closable={false}
        // onClose={this.onToggleCollapsedNav.bind(this)}
        visible={collapsed}
      >
        {children}
      </Drawer>
    ) : (
      { children }
    );

  console.log(width);

  useEffect(() => {
    window.addEventListener('resize', () => {
      setWidth(window.innerHeight);
    });
  }, []);
  return (
    <Sider
      className="gx-app-sidebar  gx-layout-sider-dark ant-layout-sider ant-layout-sider-dark"
      trigger={null}
      theme="dark"
    >
      {/* <div className="gx-layout-sider-header">
        <div className="gx-linebar">
          <i
            className={`gx-icon-btn icon icon-${
              collapsed ? 'menu-unfold' : 'menu-fold'
            } 'gx-text-white'`}
            onClick={() => {
              if (navStyle === NAV_STYLE_DRAWER) {
                this.props.toggleCollapsedSideNav(!navCollapsed);
              } else if (navStyle === NAV_STYLE_FIXED) {
                this.props.onNavStyleChange(NAV_STYLE_MINI_SIDEBAR);
              } else if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) {
                this.props.toggleCollapsedSideNav(!navCollapsed);
              } else {
                this.props.onNavStyleChange(NAV_STYLE_FIXED);
              }
            }}
          />
        </div>

        <Link to="/" className="gx-site-logo">
          {navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR &&
          width >= TAB_SIZE ? (
            <img alt="" src={require('assets/images/w-logo.png')} />
          ) : themeType === THEME_TYPE_LITE ? (
            <img alt="" src={require('assets/images/logo-white.png')} />
          ) : (
            <img alt="" src={require('assets/images/logo.png')} />
          )}
        </Link>
      </div> */}
      {children}
    </Sider>
  );
}
export default Sidebar;
