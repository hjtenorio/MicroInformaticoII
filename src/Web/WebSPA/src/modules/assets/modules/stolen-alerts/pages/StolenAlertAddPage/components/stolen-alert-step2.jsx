/* eslint-disable react/prop-types */
/* eslint-disable react/jsx-props-no-spreading */

import React, { useState } from 'react';

import { Button, Icon, Upload } from '@valtx-mi2/ui';

import ModeloDeclaracionJurada from '../files/modelo-declaracion-jurada.DOCX';

const PoliceReportAttachment = ({
  policeReportFile,
  policeReportFileChange,
}) => {
  const label = 'Denuncia Policial';
  const [fileList, setFileList] = useState(
    policeReportFile === null ? [] : [policeReportFile]
  );

  const props = {
    name: 'PoliceAlertFile',
    onRemove: () => {
      setFileList([]);
      policeReportFileChange(null);
    },
    beforeUpload: (file) => {
      setFileList([file]);
      policeReportFileChange(file);
      return false;
    },

    fileList,
  };

  return (
    <div
      css={{
        padding: '10px 0px',
        display: 'flex',
        flexDirection: 'column',
        textAlign: 'center',
      }}
    >
      <p css={{ fontSize: '1rem', fontWeight: '500', color: '#000' }}>
        {label}
      </p>
      <Upload {...props}>
        <Button css={{ width: '150px' }}>
          Subir archivo
          <Icon type="upload" />
        </Button>
      </Upload>
    </div>
  );
};

const AffidavitAttachment = ({ affidavitFile, affidavitFileChange }) => {
  const label = 'Declaracion Jurada';
  const [fileList, setFileList] = useState(
    affidavitFile === null ? [] : [affidavitFile]
  );

  const props = {
    name: 'AffidavitFile ',
    onRemove: () => {
      setFileList([]);
      affidavitFileChange(null);
    },
    beforeUpload: (file) => {
      setFileList([file]);
      affidavitFileChange(file);
      return false;
    },
    fileList,
  };

  return (
    <div>
      <div
        css={{
          padding: '10px 0px',
          display: 'flex',
          flexDirection: 'column',
          textAlign: 'center',
        }}
      >
        <p css={{ fontSize: '1rem', fontWeight: '500', color: '#000' }}>
          {label}
        </p>
        <Upload {...props}>
          <Button css={{ width: '150px' }}>
            Subir archivo
            <Icon type="upload" />
          </Button>{' '}
        </Upload>
      </div>
      <Button type="link" href={ModeloDeclaracionJurada} target="_blank">
        Ejemplo del formato de declaracion jurada
      </Button>
    </div>
  );
};

const StolenAlertStep2 = ({
  policeReportFile,
  affidavitFile,
  policeReportFileChange,
  affidavitFileChange,
}) => {
  return (
    <div
      css={{
        display: 'flex',
        justifyContent: 'space-around',
        padding: '40px 0px',
      }}
    >
      <div css={{ display: 'flex', justifyContent: 'center', flex: '1' }}>
        <PoliceReportAttachment
          policeReportFile={policeReportFile}
          policeReportFileChange={policeReportFileChange}
        />
      </div>
      <div
        css={{
          display: 'flex',
          justifyContent: 'center',
          textAlign: 'center',
          flex: '1',
        }}
      >
        <AffidavitAttachment
          affidavitFile={affidavitFile}
          affidavitFileChange={affidavitFileChange}
        />
      </div>
    </div>
  );
};

export default StolenAlertStep2;
