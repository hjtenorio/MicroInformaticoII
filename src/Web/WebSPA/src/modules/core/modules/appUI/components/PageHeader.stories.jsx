import 'antd/dist/antd.css';

import '../../../../../vendors/style';
import '../../../../../styles/wieldy.less';
import '../../../../../styles/style.css';

import React from 'react';

import { Icon, Layout, SVGIcons } from '@valtx-mi2/ui';

import { withRedux } from '../../../../../../.storybook/decorators';
import { initialState } from '../../../../../store/reducers';
import { ApplicationUIProvider } from '../hooks/useApplicationUI';
import PageHeader from './PageHeader';

const { TicketIcon } = SVGIcons;

const cannedActions = [];

export default {
  title: 'PageHeader',
  decorators: [withRedux(initialState, cannedActions)],
};

export const PageHeaderStory = () => {
  return (
    <ApplicationUIProvider>
      <Layout>
        <PageHeader>
          <Icon component={TicketIcon} /> Mis Tickets
        </PageHeader>
      </Layout>
    </ApplicationUIProvider>
  );
};
