import React from 'react';
import styled from '@emotion/styled';

const PageSectionWrapper = styled.section`
  padding: 12px;
  margin-bottom: 10px;
`;

export default function PageSection({ children }) {
  return <PageSectionWrapper>{children}</PageSectionWrapper>;
}
