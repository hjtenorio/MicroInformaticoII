/* eslint-disable react/prop-types */
import React from 'react';
import { Skeleton } from '@valtx-mi2/ui';
import StolenAlertAssetsTable from './stolen-alert-assets-table';

export default function StolenAlertStep1({ loading, data, selected, change }) {
  if (loading) return <Skeleton active />;

  return (
    <StolenAlertAssetsTable data={data} selected={selected} change={change} />
  );
}
