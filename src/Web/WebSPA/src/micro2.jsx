/*
 * @Author: gvillena
 * @Date: 2020-02-26 13:59:08
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-10 15:28:05
 */

import './vendors/style';
import './styles/wieldy.less';

import React from 'react';
import { Redirect, Switch } from 'react-router-dom';

import { css } from '@emotion/core';
import {
  AssetReturnPage,
  ReportsPage,
  StolenAlertAddPage,
  TicketAddPage,
  TicketDetailPage,
  TicketsPage,
} from '@valtx-mi2/assets';
import { AppBar, Route, Sidebar, useApplicationUI } from '@valtx-mi2/core';
import {
  ForgotPasswordPage,
  LoginPage,
  ResetPasswordPage,
  useIdentity,
} from '@valtx-mi2/identity';
import { Layout, Theme } from '@valtx-mi2/ui';

import Error404 from './pages/Error404Page';
import HomePage from './pages/HomePage';

const styles = {
  layout: css`
    height: 100vh;
  `,
};

const { Content } = Layout;

const {
  NAV_STYLE_DRAWER,
  NAV_STYLE_FIXED,
  NAV_STYLE_MINI_SIDEBAR,
  TAB_SIZE,
} = Theme;
/**
 * Micro2
 *
 * @returns
 */
function Micro2() {
  const applicationUI = useApplicationUI();

  const { navStyle, width } = applicationUI;

  const contentStyle =
    navStyle === NAV_STYLE_DRAWER ||
    ((navStyle === NAV_STYLE_FIXED || navStyle === NAV_STYLE_MINI_SIDEBAR) &&
      width < TAB_SIZE)
      ? { marginTop: '50px' }
      : null;

  return (
    <Layout css={styles.layout}>
      <Sidebar />
      <Layout>
        <AppBar />
        <Content css={contentStyle}>
          <Switch>
            <Route path="/home" component={HomePage} secured />
            <Route path="/identity/login" component={LoginPage} />
            <Route
              path="/identity/forgot-password"
              component={ForgotPasswordPage}
            />
            <Route
              path="/identity/reset-password/:token"
              component={ResetPasswordPage}
            />

            <Route
              exact
              path="/assets/tickets"
              component={TicketsPage}
              secured
            />
            <Route
              exact
              path="/assets/tickets/add"
              component={TicketAddPage}
              secured
            />
            <Route
              path="/assets/tickets/:ticketId"
              component={TicketDetailPage}
              secured
            />
            <Route
              path="/assets/stolen-alert"
              component={StolenAlertAddPage}
              secured
            />

            <Route
              path="/assets/asset-return"
              component={AssetReturnPage}
              secured
            />

            <Route path="/reports/:slug" component={ReportsPage} secured />
            <Route path="/404" component={Error404} />
            <Route exact path="/" render={() => <Redirect to="/home" />} />
            <Route render={() => <Redirect to="/404" />} />
          </Switch>
        </Content>
      </Layout>
    </Layout>
  );
}

export default Micro2;
