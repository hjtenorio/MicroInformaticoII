import 'antd/dist/antd.css';

import React from 'react';

import styled from '@emotion/styled';

import TicketQueueTimeline from './TicketQueueTimeline';

export default { title: 'TicketQueueTimeline' };

export const sampleData = () => {
  const queue = 'OTRS';

  const data = [
    {
      queueId: 59,
      articuleId: 475000,
      aBody: 'jhf kflksdjflkjsdlkfj  dfkdfj dslkjflksdf',
      createdTime: '2020-03-02T09:44:06',
      createdBy: 'MARIO VALENTIN ESCUDERO GUARDERAS',
      especialist: 'CLAUDIA ELENA CISNEROS CONTRERAS <swfiequipodes4@valtx.pe>',
      historyType: 1,
      queueDetailAttachments: [
        {
          uid: '-1',
          articuleId: 475000,
          contentType: 'image/png',
          fileName:
            'acceso denegado al documento.png; name=acceso denegado al documento.png',
          name: 'acceso denegado al documento.png',
          content:
            'iVBORw0KGgoAAAANSUhEUgAABTIAAAKGCAYAAAB5rGS5AAAAAX…AAMUTMgEAAACAwr2b/j+xG4o7tB/K9gAAAABJRU5ErkJggg==',
        },
        {
          uid: '-2',
          articuleId: 475000,
          contentType: 'image/jpeg',
          fileName:
            'documento no acceso jpg.jpg; name=documento no acceso jpg.jpg',
          name: 'documento no acceso jpg.jpg',
          content:
            '/9j/4AAQSkZJRgABAQEAYABgAAD/4QCsRXhpZgAATU0AKgAAAA…FFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAf/Z',
        },
      ],
    },
  ];

  const Container = styled.div`
    padding: 100px;
  `;

  return (
    <Container>
      <TicketQueueTimeline queue={queue} dataSource={data} />
    </Container>
  );
};
