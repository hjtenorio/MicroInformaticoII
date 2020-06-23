import React from 'react';
import PropTypes from 'prop-types';

function SiderHeader({ children }) {
  return <div className="gx-layout-sider-header">{children}</div>;
}

SiderHeader.defaultProps = {
  children: <div>Logo</div>,
};

SiderHeader.propTypes = {
  children: PropTypes.node,
};

export default SiderHeader;
