import moment from 'moment';
import React, { useDispatch, useEffect, useReducer, useState } from 'react';
import { Link, useLocation } from 'react-router-dom';

import { useIdentity } from '@valtx-mi2/identity';
import { Card, Content, Layout, Spin } from '@valtx-mi2/ui';

import TicketList from '../components/TicketList';
import TicketSearch from '../components/TicketSearch';
import Header from '../components/TicketsPageHeader';
import useTicketPaginatedList from '../hooks/useTicketPaginatedList';
import useTicketStatusList from '../hooks/useTicketStatusList';

function TicketsPage() {
  const identity = useIdentity();
  const location = useLocation();

  const { username: nroDni } = identity.user;

  const {
    ticketPaginatedList,
    ticketPaginatedListFetch,
    ticketPaginatedListFetchRequested,
    ticketPaginatedListFetchSucceeded,
  } = useTicketPaginatedList();

  const {
    ticketStatusList,
    ticketStatusListFetch,
    ticketStatusListFetchRequested,
  } = useTicketStatusList();

  const [searchParams, setSearchParams] = useState({
    nroDni,
    nroTicketTitle: '',
    serviceTypeId: 2,
    ticketStatusId: -1,
    startDate: null,
    endDate: null,
  });

  const [currentPage, setCurrentPage] = useState(1);
  const [pageSize, setPageSize] = useState(5);
  const [totalItems, setTotalItems] = useState(0);

  useEffect(() => {
    ticketStatusListFetch();
    ticketPaginatedListFetch(searchParams, currentPage, pageSize);
  }, []);

  useEffect(() => {
    ticketStatusListFetch();
    ticketPaginatedListFetch(searchParams, currentPage, pageSize);
  }, [location]);

  useEffect(() => {
    if (ticketPaginatedListFetchSucceeded) {
      setTotalItems(ticketPaginatedList.count);
    }
  }, [ticketPaginatedListFetchSucceeded]);

  function onSearch(params) {
    setCurrentPage(1);
    setPageSize(5);
    setTotalItems(0);
    setSearchParams(params);

    const startDate = params.startDate
      ? params.startDate.format('MM-DD-YYYY')
      : null;
    const endDate = params.endDate ? params.endDate.format('MM-DD-YYYY') : null;
    ticketPaginatedListFetch({ ...params, nroDni, startDate, endDate }, 1, 5);
  }

  function onPageChange(changedCurrentPage, changedPageSize) {
    setCurrentPage(changedCurrentPage);
    setPageSize(changedPageSize);
    const startDate = searchParams.startDate
      ? searchParams.startDate.format('MM-DD-YYYY')
      : null;
    const endDate = searchParams.endDate
      ? searchParams.endDate.format('MM-DD-YYYY')
      : null;
    ticketPaginatedListFetch(
      { ...searchParams, nroDni, startDate, endDate },
      changedCurrentPage,
      changedPageSize
    );
  }

  return (
    <Layout>
      <Spin spinning={ticketPaginatedListFetchRequested}>
        <Header />
        <Content css={{ padding: '0px 20px', position: 'relative' }}>
          <Card bodyStyle={{ padding: '30px 25px' }}>
            <TicketSearch
              onSearch={(params) => onSearch(params)}
              statusDataSource={ticketStatusList}
            />

            <TicketList
              dataSource={
                ticketPaginatedList.data ? ticketPaginatedList.data : []
              }
              currentPage={currentPage}
              pageSize={pageSize}
              total={totalItems}
              onPageChange={onPageChange}
            />
          </Card>
        </Content>
      </Spin>
    </Layout>
  );
}

export default TicketsPage;
