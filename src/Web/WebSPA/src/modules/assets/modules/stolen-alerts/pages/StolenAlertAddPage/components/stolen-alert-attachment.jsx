/* eslint-disable no-shadow */
/* eslint-disable react/prop-types */
/* eslint-disable react/jsx-props-no-spreading */
import React from 'react';
import { Upload, Button, Icon } from 'antd';

export default function StolenAlertAttachment({ label, ...props }) {
  return (
    <div css={{ display: 'flex', alignItems: 'center' }}>
      <span css={{ fontSize: '1rem' }}>{label}</span>
      {'  '}
      <Upload {...props}>
        <Button>
          <Icon type="upload" />
        </Button>
      </Upload>
    </div>
  );
}
