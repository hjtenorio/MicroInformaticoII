/* eslint-disable react/prop-types */
/* eslint-disable react/jsx-props-no-spreading */

import React from 'react';

import { Button, Icon, Upload } from '@valtx-mi2/ui';

export default function TicketAttachments({ fileList = [], onChange }) {
  function onRemove(file) {
    const index = fileList.indexOf(file);
    const newFileList = fileList.slice();
    newFileList.splice(index, 1);
    onChange(newFileList);
  }

  function beforeUpload(file) {
    onChange([...fileList, file]);
    return false;
  }
  return (
    <Upload fileList={fileList} beforeUpload={beforeUpload} onRemove={onRemove}>
      <Button>
        <Icon type="upload" /> Subir archivos
      </Button>
    </Upload>
  );
}
