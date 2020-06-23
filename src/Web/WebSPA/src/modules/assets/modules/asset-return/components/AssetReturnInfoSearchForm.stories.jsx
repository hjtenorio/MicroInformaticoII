import 'antd/dist/antd.css';

import React from 'react';

import styled from '@emotion/styled';

import AssetReturnInfoSearchForm from './AssetReturnInfoSearchForm';

export default { title: 'AssetReturnInfoSearchForm' };

export const AssetReturnInfoSearchFormStory = () => {
  const Container = styled.div`
    padding: 100px;
  `;

  return (
    <Container>
      <AssetReturnInfoSearchForm
        onSearchSubmit={() => console.log('onSearchSubmit')}
      />
    </Container>
  );
};
