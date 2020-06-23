/* eslint-disable no-use-before-define */
/*
 * @Author: gvillena
 * @Date: 2020-02-24 11:24:24
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-02 17:50:06
 */

import moment from 'moment';
import React, { useEffect, useState } from 'react';
import { useDispatch } from 'react-redux';
import { useLocation } from 'react-router-dom';

import { PageHeader } from '@valtx-mi2/core';
import { useIdentity } from '@valtx-mi2/identity';
import {
  Button,
  Card,
  Content,
  Layout,
  Modal,
  Result,
  SVGIcons,
  Spin,
} from '@valtx-mi2/ui';

import AssetReturnInfoSearchForm from '../components/AssetReturnInfoSearchForm';
import AssetReturnInfoTable from '../components/AssetReturnInfoTable';
import useAssetReturnInfoPaginatedList from '../hooks/useAssetReturnInfoPaginatedList';
import useAssetReturnInfoUpdate from '../hooks/useAssetReturnInfoUpdate';

const { EmployeeIcon } = SVGIcons;

/**
 * AssetReturnPage
 *
 * @returns
 */
function AssetReturnPage() {
  const dispatch = useDispatch();
  const identity = useIdentity();
  const location = useLocation();
  const { username: nroDni } = identity.user;

  const [transactionData, setTransactionData] = useState([]);

  const [searchParams, setSearchParams] = useState({
    nroDni,
    firstName: '',
    lastName: '',
    startDate: moment().format('YYYY-MM-DD'),
    endDate: moment()
      .add(1, 'months')
      .format('YYYY-MM-DD'),
  });

  const {
    assetReturnInfoPaginatedList,
    assetReturnInfoPaginatedListFetch,
    assetReturnInfoPaginatedListFetchRequested,
  } = useAssetReturnInfoPaginatedList();

  const {
    assetReturnInfoUpdateSubmit,
    assetReturnInfoUpdateSubmitRequested,
    assetReturnInfoUpdateSubmitSucceeded,
    assetReturnInfoUpdateSubmitFailed,
  } = useAssetReturnInfoUpdate();

  const [pagination, setPagination] = useState({
    current: 1,
    pageSize: 5,
    defaultCurrent: 1,
    defaultPageSize: 5,
    // eslint-disable-next-line no-use-before-define
    onChange: onPageChange,
    total: 0,
    showTotal: (total, range) =>
      `Mostrando  ${range[0]}-${range[1]} de ${total} registros`,
  });

  useEffect(() => {
    assetReturnInfoPaginatedListFetch(
      searchParams,
      pagination.current,
      pagination.pageSize
    );

    return function cleanup() {};
  }, []);

  useEffect(() => {
    assetReturnInfoPaginatedListFetch(
      searchParams,
      pagination.current,
      pagination.pageSize
    );
  }, [location]);

  useEffect(() => {
    if (assetReturnInfoUpdateSubmitSucceeded) {
      onAssetReturnInfoUpdateSubmitSucceeded();
    }
    if (assetReturnInfoUpdateSubmitFailed) {
      onAssetReturnInfoUpdateSubmitFailed();
    }
  }, [assetReturnInfoUpdateSubmitSucceeded, assetReturnInfoUpdateSubmitFailed]);

  function onPageChange(current, pageSize) {
    setPagination({ ...pagination, current, pageSize });
    assetReturnInfoPaginatedListFetch(searchParams, current, pageSize);
  }

  function onSearchSubmit(params) {
    const { startDate, endDate } = params;
    setSearchParams({
      ...params,
      nroDni,
      startDate: startDate ? startDate.format('YYYY-MM-DD') : null,
      endDate: endDate ? endDate.format('YYYY-MM-DD') : null,
    });
    setPagination({ ...pagination, current: 1, pageSize: 5 });
    assetReturnInfoPaginatedListFetch(
      {
        ...params,
        nroDni,
        startDate: startDate ? startDate.format('YYYY-MM-DD') : null,
        endDate: endDate ? endDate.format('YYYY-MM-DD') : null,
      },
      1,
      5
    );
  }

  function onSaveChanges() {
    // id:7275
    // renewalDate:"2020-03-19"
    // renewalStatus:true
    assetReturnInfoUpdateSubmit(transactionData);
    setTransactionData([]);
  }

  function getAssetReturnInfoTableDataSource() {
    // return [];
    return assetReturnInfoPaginatedList.data.map((infoItem) => {
      const transaction = transactionData.find(
        (transactionItem) => transactionItem.id === infoItem.id
      );
      return transaction === undefined
        ? infoItem
        : {
            ...infoItem,
            ...transaction,
          };
    });
  }

  function onRenewalStatusChange(record, newStatus) {
    const index = transactionData.findIndex(
      (transaction) => transaction.id === record.id
    );
    if (index !== -1) {
      const newData = [...transactionData];
      newData.splice(index, 1);
      setTransactionData([...newData]);
    } else {
      setTransactionData([
        ...transactionData,
        {
          id: record.id,
          renewalDate: newStatus
            ? moment(record.terminationDate).add(1, 'day')
            : null,
          renewalStatus: newStatus,
        },
      ]);
    }
  }

  function onRenewalDateChange(record, newDate) {
    const index = transactionData.findIndex(
      (transaction) => transaction.id === record.id
    );

    if (index !== -1) {
      const newData = transactionData.map((transaction) => {
        return transaction.id !== record.id
          ? transaction
          : { ...transaction, renewalDate: newDate };
      });
      setTransactionData([...newData]);
    } else {
      setTransactionData([
        ...transactionData,
        {
          id: record.id,
          renewalDate: newDate,
          renewalStatus: record.renewalStatus,
        },
      ]);
    }
  }

  function onAssetReturnInfoUpdateSubmitSucceeded() {
    // eslint-disable-next-line no-use-before-define
    assetReturnInfoPaginatedListFetch(
      searchParams,
      pagination.current,
      pagination.pageSize
    );
    Modal.success({
      content: (
        <Result
          status="success"
          title="RECUERDA"
          subTitle="Puedes actualizar la selección las veces que quieras, solo  hasta  un  día  antes  del  cese  del  colaborador,  pasando  la  fecha indicada, se procederá con el cese o renovación seleccionada para la devolución del equipo."
          icon={null}
        />
      ),
      okText: 'Aceptar',
    });
  }

  function onAssetReturnInfoUpdateSubmitFailed() {
    console.log('error');
  }

  return (
    <Layout>
      <Spin spinning={assetReturnInfoUpdateSubmitRequested}>
        <PageHeader>
          <EmployeeIcon /> Devolución de Equipos{' '}
        </PageHeader>

        <Content css={{ padding: '0px 20px', position: 'relative' }}>
          <Card bodyStyle={{ padding: '30px 25px' }}>
            <AssetReturnInfoSearchForm onSearchSubmit={onSearchSubmit} />
            <AssetReturnInfoTable
              loading={assetReturnInfoPaginatedListFetchRequested}
              dataSource={getAssetReturnInfoTableDataSource()}
              onRenewalStatusChange={onRenewalStatusChange}
              onRenewalDateChange={onRenewalDateChange}
              pagination={{
                ...pagination,
                total: assetReturnInfoPaginatedList.count,
              }}
            />
            <Button
              css={{ marginTop: '10px' }}
              type="primary"
              onClick={onSaveChanges}
              disabled={transactionData.length === 0}
            >
              Guardar Cambios
            </Button>
          </Card>
        </Content>
      </Spin>
    </Layout>
  );
}

export default AssetReturnPage;
