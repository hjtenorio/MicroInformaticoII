/* eslint-disable react/prop-types */

import React from 'react';

import { css } from '@emotion/core';
import { Descriptions } from '@valtx-mi2/ui';

const descriptions = css({
  margin: '50px 0px',
  '.ant-descriptions-item-label': {
    padding: '10px 24px',
    fontWeight: 700,
  },
  '.ant-descriptions-item-content': {
    padding: '10px 24px',
  },
});

const Step3 = ({ owner, asset, affidavitFile, policeReportFile }) => {
  return (
    <div>
      <Descriptions
        title="Colaborador"
        layout="vertical"
        colon={false}
        bordered
        css={descriptions}
      >
        <Descriptions.Item label="Nombres">{owner.firstName}</Descriptions.Item>
        <Descriptions.Item label="Apellidos">
          {owner.lastName}
        </Descriptions.Item>
        <Descriptions.Item label="Email" span={2}>
          {owner.email}
        </Descriptions.Item>
      </Descriptions>
      <Descriptions
        title="Equipo Robado"
        layout="vertical"
        colon={false}
        bordered
        css={descriptions}
      >
        <Descriptions.Item label="Id">{asset.id}</Descriptions.Item>
        <Descriptions.Item label="Nombre">{asset.name}</Descriptions.Item>
        <Descriptions.Item label="Modelo">{asset.model}</Descriptions.Item>
        <Descriptions.Item label="Serie">{asset.serieNro}</Descriptions.Item>
        <Descriptions.Item label="Orden de Compra">
          {asset.buyOrder}
        </Descriptions.Item>
      </Descriptions>
      <Descriptions
        title="Denuncia Policial"
        layout="vertical"
        colon={false}
        bordered
        css={descriptions}
      >
        <Descriptions.Item label="Nombre de Archivo">
          {policeReportFile.name}
        </Descriptions.Item>
        <Descriptions.Item label="Tipo">
          {policeReportFile.type}
        </Descriptions.Item>
      </Descriptions>
      <Descriptions
        title="Declaracion Jurada"
        layout="vertical"
        colon={false}
        bordered
        css={descriptions}
      >
        <Descriptions.Item label="Nombre de Archivo">
          {affidavitFile.name}
        </Descriptions.Item>
        <Descriptions.Item label="Tipo">{affidavitFile.type}</Descriptions.Item>
      </Descriptions>
    </div>
  );
};

export default Step3;
