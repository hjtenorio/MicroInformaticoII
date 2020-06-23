/** @jsx jsx */

import 'antd/dist/antd.css';

import React from 'react';

import { jsx } from '@emotion/core';
import styled from '@emotion/styled';
import { Layout } from '@valtx-mi2/ui';

import TicketsPageHeader from './TicketsPageHeader';

export default { title: 'TicketsPageHeader' };

export const TicketsPageHeaderStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;
  return (
    <Container>
      <Layout>
        <TicketsPageHeader />
      </Layout>
    </Container>
  );
};
