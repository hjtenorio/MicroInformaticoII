/** @jsx jsx */

import 'antd/dist/antd.css';

import '../../../../../vendors/style';
import '../../../../../styles/wieldy.less';
import '../../../../../styles/style.css';

import React from 'react';

import { css, jsx } from '@emotion/core';
import styled from '@emotion/styled';
import { Icon, Layout, SVGIcons } from '@valtx-mi2/ui';

import { withRedux } from '../../../../../../.storybook/decorators';
import { initialState } from '../../../../../store/reducers';
import { ApplicationUIProvider } from '../hooks/useApplicationUI';
import Header from './header';

const { TicketIcon } = SVGIcons;

const cannedActions = [];

export default {
  title: 'Header',
  decorators: [withRedux(initialState, cannedActions)],
};

export const HeaderStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  const styles = {
    layout: css`
      height: 100vh;
    `,
  };

  return (
    <ApplicationUIProvider>
      <Layout>
        <Header style={{ position: 'fixed', zIndex: 1, width: '100%' }}>
          <span>
            <Icon component={TicketIcon} style={{ 'margin-right': '3px' }} />{' '}
            Crear Ticket
          </span>
        </Header>
      </Layout>
    </ApplicationUIProvider>
  );
};
