import 'antd/dist/antd.css';

import React from 'react';

import styled from '@emotion/styled';

import TicketSearch from './TicketSearch';

export default { title: 'TicketSearch' };

export const TicketSearchStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  return (
    <Container>
      <TicketSearch
        onSearch={() => console.log('onSearch')}
        statusDataSource={[]}
      />
    </Container>
  );
};
