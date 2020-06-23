import 'antd/dist/antd.css';

import React from 'react';

import styled from '@emotion/styled';

import AssetReturnInfoTable from './AssetReturnInfoTable';

export default { title: 'AssetReturnInfoTable' };

export const AssetReturnInfoTableStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  const response = {
    pageIndex: 0,
    pageSize: 5,
    count: 20,
    data: [
      {
        id: 5683,
        email: 'swfiequipodes4@valtx.pe',
        customerId: '009393242',
        dni: '06768291',
        charge: null,
        firstName: 'NELSON EMILIO',
        lastName: 'LANCHIPA RIZABAL',
        street: null,
        phone: null,
        terminationDate: '2020-04-11T15:25:02',
        renewalDate: '2020-04-11T00:00:00',
        renewalStatus: true,
      },
      {
        id: 287,
        email: 'swfiequipodes4@valtx.pe',
        customerId: '009060413',
        dni: '10629660',
        charge: null,
        firstName: 'ERICKA YANINA',
        lastName: 'GUTIERREZ REBATTA',
        street: null,
        phone: null,
        terminationDate: '2020-04-17T00:00:00',
        renewalDate: null,
        renewalStatus: false,
      },
      {
        id: 502,
        email: 'swfiequipodes4@valtx.pe',
        customerId: '009231234',
        dni: '06731370',
        charge: null,
        firstName: 'ROSA CLEMENCIA',
        lastName: 'ORTIZ ROJAS',
        street: null,
        phone: null,
        terminationDate: '2020-04-17T00:00:00',
        renewalDate: '2020-04-17T00:00:00',
        renewalStatus: true,
      },
      {
        id: 1073,
        email: 'swfiequipodes4@valtx.pe',
        customerId: '009780629',
        dni: '10045237',
        charge: null,
        firstName: 'DAVID ROGER',
        lastName: 'SANDOVAL ESTRELLA',
        street: null,
        phone: null,
        terminationDate: '2020-04-17T00:00:00',
        renewalDate: '2020-04-17T00:00:00',
        renewalStatus: true,
      },
      {
        id: 1104,
        email: 'swfiequipodes4@valtx.pe',
        customerId: '009798595',
        dni: '43989724',
        charge: null,
        firstName: 'CHRISTIAN VICTOR',
        lastName: 'ORTEGA VARGAS',
        street: null,
        phone: null,
        terminationDate: '2020-04-17T00:00:00',
        renewalDate: '2020-04-17T00:00:00',
        renewalStatus: true,
      },
    ],
  };

  return (
    <Container>
      <AssetReturnInfoTable
        loading={false}
        dataSource={response.data}
        onRenewalStatusChange={() => console.log('onRenewalStatusChange')}
        onRenewalDateChange={(record, newDate) =>
          console.log('onRenewalDateChange', [record, newDate])
        }
        pagination={{}}
      />
    </Container>
  );
};
