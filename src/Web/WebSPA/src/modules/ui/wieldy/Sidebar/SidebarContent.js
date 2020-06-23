import { Menu } from 'antd';
import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import IntlMessages from '../../intl-messages';
import {
  NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR,
  NAV_STYLE_NO_HEADER_MINI_SIDEBAR,
  THEME_TYPE_LITE,
} from '../constants/ThemeSetting';
import Auxiliary from '../utils/auxiliary';
import CustomScrollbars from '../utils/custom-scrollbars';
import AppsNavigation from './AppsNavigation';
import SidebarLogo from './SidebarLogo';
import UserProfile from './UserProfile';

class SidebarContent extends Component {
  getNoHeaderClass = (navStyle) => {
    if (
      navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR ||
      navStyle === NAV_STYLE_NO_HEADER_EXPANDED_SIDEBAR
    ) {
      return 'gx-no-header-notifications';
    }
    return '';
  };
  getNavStyleSubMenuClass = (navStyle) => {
    if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) {
      return 'gx-no-header-submenu-popup';
    }
    return '';
  };

  render() {
    const { themeType, navStyle, pathname } = this.props;
    const selectedKeys = pathname.substr(1);
    const defaultOpenKeys = selectedKeys.split('/')[1];
    return (
      <Auxiliary>
        <SidebarLogo />
        <div className="gx-sidebar-content">
          <div
            className={`gx-sidebar-notifications ${this.getNoHeaderClass(
              navStyle
            )}`}
          >
            <UserProfile />
            <AppsNavigation />
          </div>
          <CustomScrollbars className="gx-layout-sider-scrollbar">
            <Menu
              defaultOpenKeys={[defaultOpenKeys]}
              selectedKeys={[selectedKeys]}
              theme={themeType === THEME_TYPE_LITE ? 'lite' : 'dark'}
              mode="inline"
            >
              <Menu.Item key="sample">
                <Link to="/sample">
                  <i className="icon icon-widgets" />
                  <IntlMessages id="sidebar.samplePage" />
                </Link>
              </Menu.Item>
            </Menu>
          </CustomScrollbars>
        </div>
      </Auxiliary>
    );
  }
}

SidebarContent.propTypes = {};
const mapStateToProps = ({ ui }) => {
  const { settings } = ui;
  console.log(settings.pathname);
  const pathname = '/';
  const { navStyle, themeType, locale } = settings;

  return { navStyle, themeType, locale, pathname };
};
export default connect(mapStateToProps)(SidebarContent);
