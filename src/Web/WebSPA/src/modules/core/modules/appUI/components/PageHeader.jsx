import PropTypes from 'prop-types';
import React from 'react';

import styled from '@emotion/styled';
import Icon from '@valtx-mi2/ui';

const PageHeaderWrapper = styled.div`
  display: flex;
  justify-content: left;
  padding: 28px 20px 20px;
`;

const H1 = styled.h1`
  margin: 0;
  font-size: 1.5rem;
`;

export default function PageHeader({ children }) {
  return (
    <PageHeaderWrapper>
      <H1>{children}</H1>
    </PageHeaderWrapper>
  );
}
