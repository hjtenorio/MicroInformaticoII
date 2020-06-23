/*
 * @Author: gvillena
 * @Date: 2020-02-28 15:34:16
 * @Last Modified by: mikey.zhaopeng
 * @Last Modified time: 2020-03-18 17:59:24
 */

import moment from 'moment';
import PropTypes from 'prop-types';
import React from 'react';
import { useHistory, useLocation } from 'react-router-dom';

import { Button, Table } from '@valtx-mi2/ui';

const { Column } = Table;

/**
 * TicketList
 *
 * @param {*} { dataSource, onSelect, pagination }
 * @returns
 */
function TicketList({
  dataSource,
  currentPage,
  pageSize,
  onPageChange,
  total,
}) {
  const location = useLocation();

  const history = useHistory();

  const pagination = {
    current: currentPage,
    pageSize,
    defaultCurrent: 1,
    defaultPageSize: 5,
    // eslint-disable-next-line no-use-before-define
    onChange: onPageChange,
    total,
    showTotal: (total, range) =>
      `Mostrando  ${range[0]}-${range[1]} de ${total} tickets`,
  };

  return (
    <Table dataSource={dataSource} pagination={pagination} rowKey="id">
      <Column title="No. Ticket" dataIndex="ticketNumber" key="ticketNumber" />
      <Column
        title="Tipo de Solicitud"
        dataIndex="serviceType"
        key="serviceTypeId"
      />
      <Column title="Solicitud" dataIndex="title" key="title" />
      <Column
        title="Fecha de Solicitud"
        dataIndex="createTIme"
        key="createTIme"
        render={(_, record) => (
          <span>{moment(record.createTime).format('DD/MM/YYYY')}</span>
        )}
      />
      <Column title="Estado" dataIndex="status" key="statusId" />
      <Column
        title=""
        key="viewDetail"
        render={(_, record) => (
          <Button
            css={{ marginBottom: '0px' }}
            type="link"
            onClick={() =>
              history.push(
                `${location.pathname}/${record.ticketNumber}`,
                record
              )
            }
          >
            Ver Detalle
          </Button>
        )}
      />
      );
    </Table>
  );
}

export default TicketList;
