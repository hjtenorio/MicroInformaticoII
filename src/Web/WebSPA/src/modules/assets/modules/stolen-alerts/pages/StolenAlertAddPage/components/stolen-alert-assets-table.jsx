/* eslint-disable react/prop-types */
import React, { useState } from 'react';
import { Table, Icon } from '@valtx-mi2/ui';

const locale = {
  emptyText: (
    <div
      css={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        height: '200px',
        padding: '40px 50px',
      }}
    >
      <Icon type="inbox" css={{ fontSize: '3rem', marginBottom: '10px' }} />
      <h4>
        No puede realizar ningún reporte de robo porque no hay ninguna maquina
        asignada a su nombre, de lo contrario comunicarse con su líder de equipo
        y pedir que realice el reporte de robo
      </h4>
    </div>
  ),
};

const columns = [
  {
    title: 'Modelo',
    dataIndex: 'model',
    key: 'model',
  },
  {
    title: 'No. Serie',
    dataIndex: 'name',
    key: 'name',
  },
];

export default function StolenAlertAssetsTable({ data, change, selected }) {
  const [selectedRowKeys, setSelectedRowKeys] = useState([selected]);

  const [pagination, setPagination] = useState({
    pageSize: 3,
    defaultCurrent: 1,
    defaultPageSize: 3,
    showTotal: (total, range) =>
      `Mostrando  ${range[0]}-${range[1]} de ${total} tickets`,
  });

  const rowSelection = {
    selectedRowKeys,
    onSelect: ({ id }) => {
      change(id);
    },
    onChange: (_selectedRowKeys) => {
      setSelectedRowKeys(_selectedRowKeys);
    },
    type: 'radio',
  };

  return (
    <div css={{ padding: '20px 0px' }}>
      <Table
        className="gx-table-responsive"
        rowSelection={rowSelection}
        rowKey="id"
        columns={columns}
        dataSource={data}
        locale={locale}
        pagination={pagination}
      />
    </div>
  );
}
