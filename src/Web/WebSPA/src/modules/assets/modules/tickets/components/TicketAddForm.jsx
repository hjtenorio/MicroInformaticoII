/* eslint-disable react/prop-types */

import React, { useState } from 'react';

import { css } from '@emotion/core';
import styled from '@emotion/styled';
import {
  Alert,
  Button,
  Form,
  Icon,
  Input,
  Tooltip,
  Upload,
} from '@valtx-mi2/ui';

import TicketAssetsTable from './TicketAssetsTable';
import TicketServiceSelect from './TicketServiceSelect';
import TicketAttachments from './ticket-attachments';

const { TextArea } = Input;

const tooltip = css`
  background-color: red;
`;

const SolicitudContent = (
  <div>
    <p>
      Puedes buscar desplegando la lista
      <br />
      o ingresar el nombre para que
      <br />
      le muestren los resultados
    </p>
  </div>
);
const DescripcionContent = (
  <div>
    <p>
      Debes detallar al máximo tu solicitud
      <br />
      esto ayudara a que la solución
      <br />
      brindada por el especilista sea la
      <br />
      adecuada
    </p>
  </div>
);

function TicketAddFormBase({
  form,
  onTicketAddSubmit,
  assetsList,
  assetsListFetchRequested,
  ticketServiceList,
  ticketServiceListFetchRequested,
}) {
  const { getFieldDecorator } = form;
  const [attachmentFileList, setAttachmentFileList] = useState([]);

  function onSubmit(e) {
    e.preventDefault();
    form.validateFields((err, values) => {
      if (!err) {
        console.log('Received values of form: ', values);
        onTicketAddSubmit({ ...values, attachments: attachmentFileList });
        form.resetFields();
        setAttachmentFileList([]);
      }
    });
  }
  const H2 = styled.h1`
    margin-bottom: 20px;
  `;

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
    <Form onSubmit={onSubmit} layout="vertical" colon={false} hideRequiredMark>
      <H2>Informacion de mi Equipo</H2>

      <Form.Item label={<span>Seleccione un equipo</span>}>
        {getFieldDecorator('assetId', {
          initialValue: '',
          rules: [
            {
              required: true,
              message: 'Por favor seleccione un Equipo',
            },
          ],
        })(
          <TicketAssetsTable
            loading={assetsListFetchRequested}
            data={assetsList}
          />
        )}
      </Form.Item>
      <H2>Aqui podras generar un nuevo ticket</H2>
      <Form.Item
        label={
          <span>
            Solicitud{' '}
            <Tooltip
              css={{ tooltip }}
              title={SolicitudContent}
              placement="topLeft"
            >
              <i className="icon icon-sweet-alert" />
            </Tooltip>
          </span>
        }
      >
        {getFieldDecorator('serviceId', {
          initialValue: null,
          rules: [
            {
              required: true,
              message: 'Por favor seleccione un Servicio',
            },
          ],
        })(
          <TicketServiceSelect
            data={ticketServiceList}
            loading={ticketServiceListFetchRequested}
          />
        )}
      </Form.Item>
      <Form.Item
        label={
          <span>
            Descripción{' '}
            <Tooltip title={DescripcionContent} placement="topLeft">
              <i className="icon icon-sweet-alert" />
            </Tooltip>
          </span>
        }
      >
        {getFieldDecorator('description', {
          initialValue: '',
          rules: [
            {
              required: true,
              message: 'Por favor ingrese la descripción del ticket',
            },
          ],
        })(
          <TextArea
            placeholder="Recuerda que debes detallar al máximo tu solicitud"
            rows={4}
          />
        )}
      </Form.Item>
      <Form.Item label={<span>Archivos adjuntos</span>}>
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
      <Alert message="Recuerde que toda la información ingresada debe ser la del USUARIO AFECTADO, de lo contrario el ticket generado será rechazado." />
      <Form.Item>
        <Button type="primary" htmlType="submit">
          Generar Ticket
        </Button>
      </Form.Item>
    </Form>
  );
}
const TicketAddForm = Form.create({
  name: 'ticket-add-form',
})(TicketAddFormBase);

export default TicketAddForm;

/* <TicketAttachments
            onFileListChange={(fileList) => setAttachmentsFileList(fileList)}
          /> */
