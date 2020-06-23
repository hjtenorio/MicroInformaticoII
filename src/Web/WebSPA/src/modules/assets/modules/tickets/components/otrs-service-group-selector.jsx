/* eslint-disable react/prop-types */
import React from 'react';
import { Select } from '@valtx-mi2/ui';

const { Option } = Select;

export default function OtrsServiceGroupSelector({
  data,
  change,
  value,
  loading,
}) {
  return (
    <Select
      showSearch
      style={{ width: '100%' }}
      placeholder="Ingrese o busque su tipo de solicitud"
      loading={loading}
      onChange={change}
      value={value}
    >
      {data.map((group) => {
        return <Option key={group.service2}>{group.service2}</Option>;
      })}
    </Select>
  );
}
