/* eslint-disable no-use-before-define */

import { push } from 'connected-react-router';
import React, { useEffect, useState } from 'react';
import { useDispatch } from 'react-redux';
import { useLocation } from 'react-router-dom';

import { css } from '@emotion/core';
import styled from '@emotion/styled';
import { PageHeader } from '@valtx-mi2/core';
import { useIdentity } from '@valtx-mi2/identity';
import {
  Alert,
  Button,
  Card,
  Col,
  Content,
  Icon,
  Input,
  Layout,
  Modal,
  Result,
  Row,
  SVGIcons,
  Spin,
  Tooltip,
  Typography,
} from '@valtx-mi2/ui';

import useAssetsList from '../../core/hooks/useAssetsList';
import TicketAddForm from '../components/TicketAddForm';
import TicketAssetsTable from '../components/TicketAssetsTable';
import TicketServiceSelect from '../components/TicketServiceSelect';
import TicketAttachments from '../components/ticket-attachments';
import useTicketAdd from '../hooks/useTicketAdd';
import useTicketServiceList from '../hooks/useTicketServiceList';

const { TicketIcon } = SVGIcons;
const { TextArea } = Input;
const { Text } = Typography;

function TicketAddPage() {
  const dispatch = useDispatch();
  const identity = useIdentity();
  const location = useLocation();

  const {
    assetsList,
    assetsListFetch,
    assetsListFetchRequested,
    assetsListFetchSucceeded,
    assetsListFetchFailed,
  } = useAssetsList();

  const {
    ticketServiceListFetch,
    ticketServiceListFetchRequested,
    ticketServiceListFetchSucceeded,
    ticketServiceListFetchFailed,
    ticketServiceList,
  } = useTicketServiceList();

  const {
    ticketAddSubmit,
    ticketAddSubmitRequested,
    ticketAddSubmitSucceeded,
    ticketAddSubmitSucceededTicketNumber,
    ticketAddSubmitFailed,
  } = useTicketAdd();

  useEffect(() => {
    const { username } = identity.user;
    assetsListFetch(username);
    ticketServiceListFetch();
  }, []);

  useEffect(() => {
    const { username } = identity.user;
    assetsListFetch(username);
    ticketServiceListFetch();
  }, [location]);

  useEffect(() => {
    if (ticketAddSubmitSucceeded) {
      onTicketAddSubmitSucceeded();
    }
    if (ticketAddSubmitFailed) {
      onTicketAddSubmitFailed();
    }
  }, [ticketAddSubmitSucceeded, ticketAddSubmitFailed]);

  function onTicketAddSubmit(values) {
    window.scrollTo(0, 0);
    const { username } = identity.user;
    const { assetId, serviceId, description, attachments } = values;
    ticketAddSubmit({
      userDni: username,
      assetId,
      serviceId,
      description,
      attachments,
    });
  }

  function onTicketAddSubmitSucceeded() {
    Modal.success({
      content: (
        <Result
          status="success"
          title="Su ticket será procesado"
          subTitle={`Numero de Ticket: ${ticketAddSubmitSucceededTicketNumber}`}
        />
      ),
      icon: null,
      okText: 'Aceptar',
    });
  }

  function onTicketAddSubmitFailed() {
    // TODO onTicketAddSubmitFailed
  }

  return (
    <Layout>
      <Spin spinning={ticketAddSubmitRequested}>
        <PageHeader>
          <Icon component={TicketIcon} style={{ 'margin-right': '3px' }} />{' '}
          Crear Ticket
        </PageHeader>
        <Content css={{ padding: '0px 20px', position: 'relative' }}>
          <Card bodyStyle={{ padding: '30px 25px' }}>
            <TicketAddForm
              assetsList={assetsList}
              assetsListFetchRequested={assetsListFetchRequested}
              ticketServiceList={ticketServiceList}
              ticketServiceListFetchRequested={ticketServiceListFetchRequested}
              onTicketAddSubmit={onTicketAddSubmit}
            />
          </Card>
        </Content>
      </Spin>
    </Layout>
  );
}

export default TicketAddPage;
