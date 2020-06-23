import React, { useState } from 'react';

import { Input, Select } from '@valtx-mi2/ui';

const { Option } = Select;

function TicketServiceSelect({ data, loading, value, onChange }) {
  const [serviceTypeName, setServiceTypeName] = useState('');

  const handleServiceChange = (selectedId) => {
    const service = data.find((item) => item.id === selectedId);
    setServiceTypeName(service.typeServiceName);
    if (onChange) {
      onChange(selectedId);
    }
  };

  return (
    <div css={{ display: 'flex' }}>
      <Select
        showSearch
        style={{ flex: '3', marginRight: '5px' }}
        placeholder="Ingrese o busque su solicitud"
        loading={loading}
        value={value}
        onChange={handleServiceChange}
        filterOption={(input, option) =>
          option.props.children.toLowerCase().indexOf(input.toLowerCase()) >= 0
        }
      >
        {data.map((service) => {
          return (
            <Option key={service.id} value={service.id}>
              {service.name}
            </Option>
          );
        })}
      </Select>
      <Input
        style={{ flex: '1' }}
        placeholder=""
        value={value ? serviceTypeName : ''}
        disabled
      />
    </div>
  );
}

export default TicketServiceSelect;
