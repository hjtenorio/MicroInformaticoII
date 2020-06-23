/*
 * @Author: gvillena
 * @Date: 2020-03-02 11:24:36
 * @Last Modified by: mikey.zhaopeng
 * @Last Modified time: 2020-03-28 12:55:55
 */

import { push } from 'connected-react-router';
import React, { useEffect, useState } from 'react';
import { useDispatch } from 'react-redux';
import { useLocation, useParams } from 'react-router-dom';

import { css } from '@emotion/core';
import {
  Alert,
  Card,
  Content,
  Layout,
  Modal,
  Result,
  SVGIcons,
  Spin,
} from '@valtx-mi2/ui';

import TicketDetail from '../components/TicketDetail';
import TicketDetailAdd from '../components/TicketDetailAdd';
import TicketQueueTimeline from '../components/TicketQueueTimeline';
import TicketStatus from '../components/TicketStatus';
import TicketsDetailPageHeader from '../components/TicketsDetailPageHeader';
import useTicketDetailData from '../hooks/useTicketDetailData';
import useTicketDetailUpdate from '../hooks/useTicketDetailUpdate';
import useTicketQueueDetailData from '../hooks/useTicketQueueDetailData';
import useTicketStatusData from '../hooks/useTicketStatusData';

const ticketStatus = css({ padding: '20px 30px' });

const { TicketIcon } = SVGIcons;

function TicketDetailPage() {
  const dispatch = useDispatch();

  const params = useParams();
  const ticketId = params.ticketId ? params.ticketId : null;

  const location = useLocation();
  const ticketData = location.state;

  const [isLoading, setIsLoading] = useState(false);
  const [isQueueTimelineVisible, setIsQueueTimelineVisible] = useState(false);
  const [activeQueue, setActiveQueue] = useState('');

  const [
    ticketStatusData,
    fetchTicketStatusData,
    isTicketStatusDataLoading,
  ] = useTicketStatusData();

  const [
    ticketDetailData,
    fetchTicketDetailData,
    isTicketDetailDataLoading,
  ] = useTicketDetailData();

  const [
    ticketQueueDetailData,
    fetchTicketQueueDetailData,
    isTicketQueueDetailDataLoading,
  ] = useTicketQueueDetailData();

  const {
    ticketDetailUpdateSubmit,
    ticketDetailUpdateSubmitRequested,
    ticketDetailUpdateSubmitSucceeded,
    ticketDetailUpdateSubmitFailed,
  } = useTicketDetailUpdate();

  useEffect(() => {
    fetchTicketStatusData(ticketId);
    fetchTicketDetailData(ticketId);
  }, []);

  useEffect(() => {
    fetchTicketStatusData(ticketId);
    fetchTicketDetailData(ticketId);
  }, [location]);

  useEffect(() => {
    setIsLoading(isTicketStatusDataLoading || isTicketDetailDataLoading);
  }, [isTicketStatusDataLoading, isTicketDetailDataLoading]);

  useEffect(() => {
    if (ticketDetailUpdateSubmitRequested) {
      setIsLoading(true);
    }
    if (ticketDetailUpdateSubmitSucceeded) {
      fetchTicketStatusData(ticketId);
      fetchTicketDetailData(ticketId);
      Modal.success({
        content: (
          <Result
            status="success"
            title="Se actualizo correctamente su ticket."
          />
        ),
        icon: null,
        okText: 'Aceptar',
      });
    }
  }, [ticketDetailUpdateSubmitRequested, ticketDetailUpdateSubmitSucceeded]);

  useEffect(() => {
    setIsLoading(isTicketQueueDetailDataLoading);
  }, [isTicketQueueDetailDataLoading]);

  function onShowQueueTimeline(queue) {
    setIsQueueTimelineVisible(true);
    setActiveQueue(queue);
    fetchTicketQueueDetailData(ticketId, queue);
  }

  function onHideQueueTimeline() {
    setIsQueueTimelineVisible(false);
    setActiveQueue(null);
  }

  function onTicketDetailAddSaveChanges(values) {
    ticketDetailUpdateSubmit({ ticketId, ...values });
  }

  const isTicketClosed = () =>
    ticketData.statusId === 2 || ticketData.statusId === 3;

  return (
    <Layout>
      <Spin spinning={isLoading}>
        <TicketsDetailPageHeader />
        <Content css={{ padding: '0px 20px', position: 'relative' }}>
          <Card bodyStyle={{ padding: '30px 25px' }}>
            {ticketData.statusId === 2 && (
              <Alert
                css={{
                  textAlign: 'center',
                  fontSize: '1.4rem',
                  fontWeight: 400,
                }}
                message="Ticket Cerrado Satisfactoriamente"
                type="success"
              />
            )}

            {ticketData.statusId === 3 && (
              <Alert
                message="Ticket Cerrado Insatisfactoriamente"
                type="error"
              />
            )}
            <TicketStatus
              css={ticketStatus}
              dataSource={ticketStatusData}
              onShowQueueTimeline={onShowQueueTimeline}
              onHideQueueTimeline={onHideQueueTimeline}
              isQueueTimelineVisible={isQueueTimelineVisible}
              activeQueue={activeQueue}
              ticketData={ticketData}
            />

            {!isQueueTimelineVisible && (
              <div>
                <TicketDetail ticket={ticketDetailData} />
                {ticketData.statusId !== 2 && ticketData.statusId !== 3 && (
                  <TicketDetailAdd
                    onSaveChanges={(values) =>
                      onTicketDetailAddSaveChanges(values)
                    }
                  />
                )}
              </div>
            )}

            {isQueueTimelineVisible && (
              <TicketQueueTimeline
                dataSource={ticketQueueDetailData}
                queue={activeQueue}
              />
            )}
          </Card>
        </Content>
      </Spin>
    </Layout>
  );
}

export default TicketDetailPage;
