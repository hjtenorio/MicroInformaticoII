/*
 * @Author: gvillena
 * @Date: 2020-03-02 13:23:52
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-02 13:25:23
 */

import moment from 'moment';
import React from 'react';

import styled from '@emotion/styled';
import { Descriptions } from '@valtx-mi2/ui';

const H1 = styled.h1({
  fontSize: '1.3rem',
  marginTop: 10,
  marginBottom: 20,
});

const descriptions = {
  margin: '50px 0px',
  '.ant-descriptions-item-label': {
    padding: '10px 24px',
  },
  '.ant-descriptions-item-content': {
    padding: '10px 24px',
  },
};
function TicketDetail({ ticket }) {
  function onAddNoteSubmit() {
    console.log('onAddNoteSubmit');
  }

  return (
    <div css={{ marginLeft: 20, marginRight: 20 }}>
      <H1>
        Tu ticket es el numero {ticket.tn} y el resumen de sus caracteristicas
        es el siguiente:
      </H1>
      <Descriptions css={descriptions} layout="vertical" colon={false} bordered>
        <Descriptions.Item
          label={<span css={{ fontWeight: 500 }}>Solicitud</span>}
        >
          {ticket.title}
        </Descriptions.Item>
        <Descriptions.Item
          label={<span css={{ fontWeight: 500 }}>Prioridad</span>}
        >
          {/* label={<span css={{ fontWeight: 500 }}>Solicitud</span>} */}
          {ticket.ticketPriority}
        </Descriptions.Item>
        <Descriptions.Item
          label={
            <span css={{ fontWeight: 500 }}>Tiempo aprox. de atencion</span>
          }
        >
          {ticket.diferenceTime}
        </Descriptions.Item>
        <Descriptions.Item
          label={<span css={{ fontWeight: 500 }}>Descripcion</span>}
          span={3}
        >
          {ticket.ticketArticle && ticket.ticketArticle.aBody}
        </Descriptions.Item>
      </Descriptions>
    </div>
  );
}

export default TicketDetail;

// id: 86650
// tn: "080084366"
// title: "Robo del equipo HN061303"
// ticketPriorityId: 2
// ticketPriority: "Incidencia"
// customerId: "007003330"
// createTime: "2020-03-03T20:55:16"
// ticketArticle:
// id: 475004
// ticketId: 86650
// aBody: "Robo del siguiente activo: Código: 08135007223, Modelo: HN061303, Serie: 5CG7253BRW"
// __proto__: Object
