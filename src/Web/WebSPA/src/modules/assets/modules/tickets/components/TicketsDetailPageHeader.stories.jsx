import 'antd/dist/antd.css';

import { ConnectedRouter } from 'connected-react-router';
import createBrowserHistory from 'history';
import React from 'react';

import styled from '@emotion/styled';

import TicketsDetailPageHeader from './TicketsDetailPageHeader';

export default { title: 'TicketsDetailPageHeader' };

export const TicketsDetailPageHeaderStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  const history = createBrowserHistory();

  return (
    <Container>
      <ConnectedRouter>
        <TicketsDetailPageHeader />
      </ConnectedRouter>
    </Container>
  );
};
