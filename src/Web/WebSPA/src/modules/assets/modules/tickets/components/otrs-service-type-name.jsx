/* eslint-disable react/prop-types */
import React from 'react';
import { Input } from 'antd';

export default function OtrsSeviceTypeName({ value }) {
  return (
    <div>
      <Input value={value} disabled="true" />
    </div>
  );
}
