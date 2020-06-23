import 'antd/dist/antd.css';

import React from 'react';

import styled from '@emotion/styled';

import StolenAlertAssetsTable from './stolen-alert-assets-table';

export default { title: 'StolenAlertAssetsTable' };

export const StolenAlertAssetsTableStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  const data = [
    {
      id: '08135008298',
      name: 'HN061780',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153T9L',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008299',
      name: 'HN061781',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153T4W',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008300',
      name: 'HN061782',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153T55',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008301',
      name: 'HN061783',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153YZG',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008302',
      name: 'HN061784',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153YQ3',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008303',
      name: 'HN061785',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153Y9Q',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008304',
      name: 'HN061786',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153YDY',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008305',
      name: 'HN061787',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153YCL',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008306',
      name: 'HN061788',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153TB2',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008307',
      name: 'HN061789',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153T46',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008308',
      name: 'HN061790',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153Y98',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008310',
      name: 'HN061792',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153Y9G',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008311',
      name: 'HN061793',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153YKQ',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008312',
      name: 'HN061794',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153T7C',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
    {
      id: '08135008313',
      name: 'HN061795',
      model: 'PROBOOK 640 G2',
      serieNro: '5CG8153SX6',
      buyOrder: '4720862953',
      type: 'Laptop',
    },
  ];

  return (
    <Container>
      <StolenAlertAssetsTable
        data={data}
        change={() => console.log('change')}
        selected={() => console.log('selected')}
      />
    </Container>
  );
};
