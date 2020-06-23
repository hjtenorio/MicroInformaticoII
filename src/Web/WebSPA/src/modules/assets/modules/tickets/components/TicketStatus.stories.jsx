import 'antd/dist/antd.css';

import React from 'react';

import styled from '@emotion/styled';

import TicketStatus from './TicketStatus';

export default { title: 'TicketStatus' };

export const ticketStatusStory = () => {
  const dataSource = [
    {
      ticketNumber: '080058108',
      typeID: '7',
      type: 'Requerimiento',
      work: '',
      queue: 'Base::Base Lima::Base San Borja',
      processQueue: 'Helpdesk',
      startTime: '2018-10-30 12:17:21',
      endTime: '2018-10-30 12:17:48',
      diferenceTime: '00:00:27',
      status: 'Finalizado',
    },
    {
      ticketNumber: '080058108',
      typeID: '7',
      type: 'Requerimiento',
      work: '',
      queue: 'Base::Base Lima::Base San Borja',
      processQueue: 'Base::Base Lima::Base San Borja',
      startTime: '2018-10-30 12:17:48',
      endTime: '2018-11-15 15:54:31',
      diferenceTime: '387:36:43',
      status: 'Finalizado',
    },
    {
      ticketNumber: '080058108',
      typeID: '7',
      type: 'Requerimiento',
      work: '',
      queue: 'Base::Base Lima::Base San Borja',
      processQueue: 'Helpdesk',
      startTime: '2018-11-15 15:54:31',
      endTime: '2018-11-15 16:08:59',
      diferenceTime: '00:14:28',
      status: 'Finalizado',
    },
    {
      ticketNumber: '080058108',
      typeID: '7',
      type: 'Requerimiento',
      work: '',
      queue: 'Base::Base Lima::Base San Borja',
      processQueue: 'Helpdesk::Gestión Helpdesk',
      startTime: '2018-11-15 16:08:59',
      endTime: '2018-11-16 15:13:42',
      diferenceTime: '23:04:43',
      status: 'Finalizado',
    },
    {
      ticketNumber: '080058108',
      typeID: '7',
      type: 'Requerimiento',
      work: '',
      queue: 'Base::Base Lima::Base San Borja',
      processQueue: 'Base',
      startTime: '2018-11-16 15:13:42',
      endTime: '2018-11-16 15:18:06',
      diferenceTime: '00:04:24',
      status: 'Finalizado',
    },
    {
      ticketNumber: '080058108',
      typeID: '7',
      type: 'Requerimiento',
      work: '',
      queue: 'Base::Base Lima::Base San Borja',
      processQueue: 'Base::Base Lima::Base San Borja',
      startTime: '2018-11-16 15:18:06',
      endTime: '2018-11-16 18:27:38',
      diferenceTime: '03:09:32',
      status: 'Finalizado',
    },
    {
      ticketNumber: '080058108',
      typeID: '7',
      type: 'Requerimiento',
      work: '',
      queue: 'Atención Finalizada',
      processQueue: 'Atención Finalizada',
      startTime: '',
      endTime: '',
      diferenceTime: '',
      status: 'Fin de atención',
    },
  ];

  const Container = styled.div`
    padding: 100px;
  `;
  return (
    <Container>
      <TicketStatus
        dataSource={dataSource}
        onShowQueueTimeline={() => console.log('onShowQueueTimeline')}
        onHideQueueTimeline={() => console.log('onHideQueueTimeline')}
        isQueueTimelineVisible={false}
      />
    </Container>
  );
};
