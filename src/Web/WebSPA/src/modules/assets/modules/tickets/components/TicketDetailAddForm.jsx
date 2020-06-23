/* eslint-disable react/prop-types */

import React, { useState } from 'react';

import { Button, Form, Icon, Input, Upload } from '@valtx-mi2/ui';

const styles = {
  formItem: {
    '& .ant-form-item': {
      margin: '0px 0px 15px 0px',
    },
  },
};

const { TextArea } = Input;

function TicketDetailAddFormBase({ form, onSaveChanges }) {
  const { getFieldDecorator } = form;
  const [attachmentFileList, setAttachmentFileList] = useState([]);

  function onSubmit(e) {
    e.preventDefault();
    form.validateFields((err, values) => {
      if (!err) {
        console.log('Received values of form: ', values);
        onSaveChanges({ ...values, attachments: attachmentFileList });
        form.resetFields();
        setAttachmentFileList([]);
      }
    });
  }

  function onAttachmentRemove(file) {
    const index = attachmentFileList.indexOf(file);
    const newFileList = attachmentFileList.slice();
    newFileList.splice(index, 1);
    setAttachmentFileList(newFileList);
  }

  function onAttachmentBeforeUpload(file) {
    setAttachmentFileList([...attachmentFileList, file]);
    return false;
  }

  return (
    <Form onSubmit={onSubmit} layout="vertical" css={styles.formItem}>
      <Form.Item label="Notas">
        {getFieldDecorator('description', {})(<TextArea rows={4} />)}
      </Form.Item>

      <Form.Item label="Archivos adjuntos">
        {getFieldDecorator(
          'attachments',
          {}
        )(
          <Upload
            fileList={attachmentFileList}
            onRemove={onAttachmentRemove}
            beforeUpload={onAttachmentBeforeUpload}
          >
            <Button>
              <Icon type="upload" /> Subir archivos
            </Button>
          </Upload>
        )}
      </Form.Item>
      <Form.Item>
        <Button type="primary" htmlType="submit">
          Enviar
        </Button>
      </Form.Item>
    </Form>
  );
}
const TicketDetailAddForm = Form.create({
  name: 'ticket-detail-add-form',
})(TicketDetailAddFormBase);

export default TicketDetailAddForm;
