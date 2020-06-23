import React from 'react';
import { Link } from 'react-router-dom';

const SiderbarLogo = () => {
  return (
    <div className="gx-layout-sider-header">
      {/* <div className="gx-linebar">
        <i
          className={`gx-icon-btn icon icon-${'menu-fold'} ${'gx-text-white'}`}
          onClick={() => {
            // if (navStyle === NAV_STYLE_DRAWER) {
            //   this.props.toggleCollapsedSideNav(!navCollapsed);
            // } else if (navStyle === NAV_STYLE_FIXED) {
            //   this.props.onNavStyleChange(NAV_STYLE_MINI_SIDEBAR);
            // } else if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) {
            //   this.props.toggleCollapsedSideNav(!navCollapsed);
            // } else {
            //   this.props.onNavStyleChange(NAV_STYLE_FIXED);
            // }
          }}
        />
      </div> */}
      <Link to="/" className="gx-site-logo">
        <img alt="" src={require('../../../assets/images/valtx-logo.svg')} />
      </Link>
    </div>
  );
};

export default SiderbarLogo;
