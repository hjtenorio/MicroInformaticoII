/* eslint-disable react/prop-types */
import React from 'react';
import styled from '@emotion/styled';
import TicketDetailAddForm from './TicketDetailAddForm';

const H1 = styled.h1({
  fontSize: '1.3rem',
  marginTop: 20,
  marginBottom: 20,
});

function TicketDetailAdd({ onSaveChanges }) {
  return (
    <div css={{ marginLeft: 20, marginRight: 20 }}>
      <H1>¿Olvidaste Algo?, agregalo aqui:</H1>
      <TicketDetailAddForm onSaveChanges={(values) => onSaveChanges(values)} />
    </div>
  );
}

export default TicketDetailAdd;
