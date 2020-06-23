import React from 'react';

import { Content, Layout } from '@valtx-mi2/ui';

import BgImage from '../img/bg-image.jpg';

export default function HomePage() {
  return (
    <Layout css={{ height: '100%' }}>
      <Content css={{ overflow: 'hidden' }}>
        <div
          css={{
            height: '100%',
            textAlign: 'center',
            display: 'flex',
            justifyContent: 'center',
            alignItems: 'center',
          }}
        >
          <img src={BgImage} alt="" />
        </div>
      </Content>
    </Layout>
  );
}
