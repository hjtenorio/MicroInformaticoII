import React from 'react';
import { Layout } from 'antd';
import PropTypes from 'prop-types';

const { Sider: BaseSider } = Layout;

function Sider(props) {
  const { children, ...rest } = props;
  return (
    // eslint-disable-next-line react/jsx-props-no-spreading
    <BaseSider className="gx-app-sidebar gx-layout-sider-dark" {...rest}>
      {children}
    </BaseSider>
  );
}

Sider.defaultProps = {
  children: <div>Sider</div>,
  rest: null,
};

Sider.propTypes = {
  children: PropTypes.node,
  // eslint-disable-next-line react/forbid-prop-types
  rest: PropTypes.array,
};

export default Sider;
