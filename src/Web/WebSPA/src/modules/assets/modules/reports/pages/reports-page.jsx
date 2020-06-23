/* eslint-disable default-case */

import React, { useEffect, useState } from 'react';
import Iframe from 'react-iframe';
import { useParams } from 'react-router-dom';

import styled from '@emotion/styled';
import { PageHeader } from '@valtx-mi2/core';
import { Content, Icon, Layout } from '@valtx-mi2/ui';

const ReportIframe = styled(Iframe)`
  border: none;
  width: 100%;
  height: 100%;
`;

export default function AssetsReportsPage() {
  const [htmlReportUrl, setHtmlReportUrl] = useState('');

  const { slug } = useParams();

  useEffect(() => {
    let reportPath;
    switch (slug) {
      case 'indicadores-generales':
        reportPath =
          'ReportServer_EDI_DESA/Pages/ReportViewer.aspx?/P200792/CAI/Reports/Dashboard&rs:Command=Render';
        break;
      case 'alertas':
        reportPath =
          'ReportServer_EDI_DESA/Pages/ReportViewer.aspx?/P200792/CAI/Reports/Alertas&rs:Command=Render';
        break;
      case 'seguimiento-activos':
        reportPath =
          'ReportServer_EDI_DESA/Pages/ReportViewer.aspx?/P200792/CAI/Reports/SeguimientoActivos&rs:Command=Render';
        break;
    }
    setHtmlReportUrl(
      `${process.env.REACT_APP_API_GESREP_PROXY_URL}/${reportPath}`
    );
  }, [slug]);

  const Headers = {
    'indicadores-generales': 'Reporte de Indicadores Generales',
    alertas: 'Reporte de Alertas',
    'seguimiento-activos': 'Seguimiento de Activos Informaticos',
  };

  return (
    <Layout css={{ height: '100%' }}>
      <PageHeader>
        <span>
          <Icon type="pie-chart" style={{ 'margin-right': '3px' }} />{' '}
          {Headers[slug]}
        </span>
      </PageHeader>
      <Content css={{ height: '100%' }}>
        <ReportIframe url={htmlReportUrl} />
      </Content>
    </Layout>
  );
}
