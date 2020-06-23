/* eslint-disable react/prop-types */
/*
 * @Author: mikey.zhaopeng
 * @Date: 2020-02-24 11:23:49
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-02 18:23:39
 */

import moment from 'moment';
import React from 'react';

import { css } from '@emotion/core';
import { DatePicker, Icon, Switch, Table } from '@valtx-mi2/ui';

const { Column } = Table;

/**
 * AssetReturnInfoTable
 * @param {*} props
 */
function AssetReturnInfoTable({
  loading,
  dataSource,
  onRenewalStatusChange,
  onRenewalDateChange,
  pagination,
}) {
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
          No se encontro colaboradores que esten proximos a finalizar su
          contrato.
          {/* No puede realizar ningún reporte de robo porque no hay ninguna maquina
          asignada a su nombre, de lo contrario comunicarse con su líder de
          equipo y pedir que realice el reporte de robo */}
        </h4>
      </div>
    ),
  };

  const tableStyle = css({
    textAlign: 'center',
    '& .ant-table-header-column': {
      textAlign: 'center',
      width: '100%',
    },
    '.ant-table-thead > tr > th, .ant-table-tbody > tr > td': {
      padding: '10px',
    },
  });

  return (
    <Table
      className="gx-table-responsive"
      dataSource={dataSource}
      rowKey="id"
      bordered
      loading={loading}
      pagination={pagination}
      locale={locale}
      css={tableStyle}
    >
      <Column title="Nombres" key="firstName" dataIndex="firstName" />
      <Column title="Apellidos" key="lastName" dataIndex="lastName" />
      <Column
        title="Cese"
        dataIndex="terminationDate"
        key="terminationDate"
        render={(text) => <span>{moment(text).format('DD/MM/YYYY')}</span>}
      />
      <Column
        title="Fecha de fin de Renovación"
        key="renewalDate"
        render={(text, record) => {
          return (
            <div css={{ textAlign: 'center' }}>
              {!record.renewalStatus ? (
                <span>NO RENUEVA</span>
              ) : (
                <DatePicker
                  defaultPickerValue={moment(record.terminationDate).add(
                    1,
                    'd'
                  )}
                  allowClear={false}
                  value={moment(record.renewalDate)}
                  size="small"
                  placeholder="Seleccione una fecha"
                  format="DD-MM-YYYY"
                  disabledDate={(current) => {
                    return (
                      current.valueOf() <
                      moment(record.terminationDate)
                        .add(1, 'd')
                        .valueOf()
                    );
                  }}
                  onChange={(newDate) =>
                    onRenewalDateChange(
                      record,
                      newDate ? newDate.format('YYYY-MM-DD') : null
                    )
                  }
                />
              )}
            </div>
          );
        }}
      />
      <Column
        title="Renueva"
        key="renewalStatus"
        render={(_, record) => {
          return (
            <Switch
              checkedChildren="Si"
              unCheckedChildren="No"
              checked={record.renewalStatus}
              onChange={(status) => {
                onRenewalStatusChange(record, status);
              }}
            />
          );
        }}
      />
    </Table>
  );
}

export default AssetReturnInfoTable;
