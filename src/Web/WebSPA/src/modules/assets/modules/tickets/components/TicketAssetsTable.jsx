/* eslint-disable react/prop-types */

import { Pagination } from 'antd';
import React, { useState } from 'react';

import { Table, Typography } from '@valtx-mi2/ui';

const { Text } = Typography;

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

export default function AssetTable({ loading, data, onChange, value = '' }) {
  const [pagination, setPagination] = useState({
    pageSize: 3,
    defaultCurrent: 1,
    defaultPageSize: 3,
    showTotal: (total, range) =>
      `Mostrando ${range[0]}-${range[1]} de ${total} equipos `,
  });

  const rowSelection = {
    selectedRowKeys: [value],
    onChange: (selectedRowKeys) => {
      const changedValue = selectedRowKeys[0];
      if (onChange) {
        onChange(changedValue);
      }
    },
    type: 'radio',
  };

  return (
    <div css={{ marginBottom: '10px' }}>
      <Table
        className="gx-table-responsive"
        rowSelection={rowSelection}
        rowKey="id"
        columns={columns}
        dataSource={data}
        loading={loading}
        pagination={pagination}
        size="small"
      />
    </div>
  );
}
