/* eslint-disable react/prop-types */
import React from 'react';
import { Select } from '@valtx-mi2/ui';

const { Option } = Select;

export default function OtrsServiceSelector({ data, value, loading, change }) {
  return (
    <div>
      <Select
        showSearch
        style={{ width: '100%' }}
        placeholder="Ingrese o busque su solicitud"
        loading={loading}
        value={value}
        onChange={change}
      >
        {data.map((service) => {
          return <Option key={service.service3}>{service.service3}</Option>;
        })}
      </Select>
    </div>
  );
}
