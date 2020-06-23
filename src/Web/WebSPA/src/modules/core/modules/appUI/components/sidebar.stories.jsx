/** @jsx jsx */

import 'antd/dist/antd.css';

import '../../../../../vendors/style';
import '../../../../../styles/wieldy.less';
import '../../../../../styles/style.css';

import { ConnectedRouter } from 'connected-react-router';
import React from 'react';

import { css, jsx } from '@emotion/core';
import styled from '@emotion/styled';
import { IdentityContext } from '@valtx-mi2/identity';
import { Layout } from '@valtx-mi2/ui';

import { withRedux } from '../../../../../../.storybook/decorators';
import { initialState } from '../../../../../store/reducers';
import history from '../../../../../utils/history';
import { ApplicationUIProvider } from '../hooks/useApplicationUI';
import Sidebar from './sidebar';

const cannedActions = [
  {
    name: 'TOGGLE_SIDEBAR_COLLAPSED',
    action: {
      type: 'TOGGLE_SIDEBAR_COLLAPSED',
    },
  },
];

export default {
  title: 'Sidebar',
  decorators: [withRedux(initialState, cannedActions)],
};

function IdentityProvider({ children }) {
  const response = {
    authToken: {},
    response: {
      data: {
        ultimoAccesso: '2020-03-29T14:44:34.517',
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
  const { authToken: token, response: raisResponse, menu: raisMenu } = response;

  const user = {
    username: raisResponse.data.username,
    firstName: raisResponse.data.nombre,
    lastName: raisResponse.data.apellido,
    email: raisResponse.data.email,
  };
  const menu = raisMenu.menu.map((menuItem) => {
    return {
      id: menuItem.id,
      title: menuItem.title,
      children: menuItem.children,
    };
  });

  const value = {
    user,
    token,
    menu,
    isAuthenticated: false,
    logout: () => console.log('logout'),
    reset: () => console.log('reset'),
    sessionStart: null,
  };

  return (
    <IdentityContext.Provider value={value}>
      {children}
    </IdentityContext.Provider>
  );
}

export const SidebarStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  const styles = {
    layout: css`
      height: 100vh;
    `,
  };

  return (
    <ConnectedRouter history={history}>
      <IdentityProvider>
        <ApplicationUIProvider>
          <Sidebar />
        </ApplicationUIProvider>
      </IdentityProvider>
    </ConnectedRouter>
  );
};
