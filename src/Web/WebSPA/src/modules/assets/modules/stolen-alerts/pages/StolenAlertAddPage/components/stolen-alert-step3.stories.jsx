import 'antd/dist/antd.css';

import React from 'react';

import styled from '@emotion/styled';

import StolenAlertStep3 from './stolen-alert-step3';

export default { title: 'StolenAlertStep3' };

export const StolenAlertStep3Story = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  const data = [
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

  const identity = {
    response: {
      data: {
        ultimoAccesso: '2020-03-27T15:40:17.727',
        apellido: 'CISNEROS CONTRERAS',
        email: 'swfiequipodes4@valtx.pe',
        idUsuario: 2330,
        nombre: 'CLAUDIA ELENA',
        perfil: 1065,
        perfiles: [1065],
        username: '10004158',
      },
      id: 0,
      message: null,
      success: true,
      total: 0,
    },
    menu: {
      menu: [
        {
          icono: 'fa fa-tachometer',
          id: 107,
          idObj: '0',
          key: '107',
          nivel: 1,
          nomMenu: 'MicroInformatico',
          opcionCritica: false,
          secu: null,
          secude: null,
          secupr: null,
          url: '',
          checkbox: false,
          children: [
            {
              icono: 'fa fa-home',
              id: 119,
              idObj: '1',
              key: '107_119',
              nivel: 2,
              nomMenu: 'Inicio',
              opcionCritica: false,
              secu: null,
              secude: null,
              secupr: null,
              url: '/home',
              checkbox: false,
              children: null,
              esPagina: true,
              expanded: true,
              iconTooltip: 'fa fa-home',
              selected: false,
              title: 'Inicio',
            },
            {
              icono: 'fa fa-area-chart',
              id: 108,
              idObj: '1',
              key: '107_108',
              nivel: 2,
              nomMenu: 'Nuevo Ticket',
              opcionCritica: false,
              secu: null,
              secude: null,
              secupr: null,
              url: '/assets/tickets/add',
              checkbox: false,
              children: null,
              esPagina: true,
              expanded: true,
              iconTooltip: 'fa fa-area-chart',
              selected: false,
              title: 'Nuevo Ticket',
            },
            {
              icono: 'fa fa-tasks',
              id: 109,
              idObj: '1',
              key: '107_109',
              nivel: 2,
              nomMenu: 'Mis Tickets',
              opcionCritica: false,
              secu: null,
              secude: null,
              secupr: null,
              url: '/assets/tickets',
              checkbox: false,
              children: null,
              esPagina: true,
              expanded: true,
              iconTooltip: 'fa fa-tasks',
              selected: false,
              title: 'Mis Tickets',
            },
            {
              icono: 'fa fa-tasks',
              id: 110,
              idObj: '1',
              key: '107_110',
              nivel: 2,
              nomMenu: 'Devolución Equipo',
              opcionCritica: false,
              secu: null,
              secude: null,
              secupr: null,
              url: '/assets/asset-return',
              checkbox: false,
              children: null,
              esPagina: true,
              expanded: true,
              iconTooltip: 'fa fa-tasks',
              selected: false,
              title: 'Devolución Equipo',
            },
            {
              icono: 'fa fa-tasks',
              id: 111,
              idObj: '1',
              key: '107_111',
              nivel: 2,
              nomMenu: 'Reportar Robo',
              opcionCritica: false,
              secu: null,
              secude: null,
              secupr: null,
              url: '/assets/stolen-alert',
              checkbox: false,
              children: null,
              esPagina: true,
              expanded: true,
              iconTooltip: 'fa fa-tasks',
              selected: false,
              title: 'Reportar Robo',
            },
          ],
          esPagina: false,
          expanded: true,
          iconTooltip: 'fa fa-tachometer',
          selected: false,
          title: 'MicroInformatico',
        },
      ],
      oPerfil: {
        actualizar: true,
        audUpdate: null,
        comentario: null,
        descripcion: null,
        eliminar: true,
        get: true,
        id: 0,
        idSistema: 3,
        insertar: true,
      },
      urlPages: [
        { id: '96', opcCritica: '0', url: '/home' },
        { id: '119', opcCritica: '0', url: '/home' },
        { id: '108', opcCritica: '0', url: '/assets/tickets/add' },
        { id: '109', opcCritica: '0', url: '/assets/tickets' },
        { id: '110', opcCritica: '0', url: '/assets/asset-return' },
        { id: '111', opcCritica: '0', url: '/assets/stolen-alert' },
        { id: '112', opcCritica: '0', url: 'url14' },
      ],
    },
  };

  return (
    <Container>
      <StolenAlertStep3
        owner={{}}
        asset={{}}
        affidavitFile={{}}
        policeReportFile={{}}
      />
    </Container>
  );
};
