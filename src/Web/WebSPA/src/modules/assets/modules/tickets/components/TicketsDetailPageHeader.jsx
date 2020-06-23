import React from 'react';
import { Link } from 'react-router-dom';

import { css } from '@emotion/core';
import { PageHeader } from '@valtx-mi2/core';
import { Breadcrumb, Button, Icon, SVGIcons } from '@valtx-mi2/ui';

const { TicketIcon } = SVGIcons;

const style = css({
  position: 'fixed',
  zindex: 1,
  width: '100%',
  backgroundColor: '#fff',
});

export default function TicketsDetailPageHeader() {
  return (
    <PageHeader css={style}>
      <span>
        <Icon component={TicketIcon} />
        <Breadcrumb
          css={{
            marginLeft: '5px',
            display: 'inline-block',
            fontSize: '1.4rem',
          }}
        >
          <Breadcrumb.Item>
            <a href="/assets/tickets">Mis Tickets</a>
          </Breadcrumb.Item>
          <Breadcrumb.Item>Detalle Ticket</Breadcrumb.Item>
        </Breadcrumb>
      </span>
    </PageHeader>
  );
}
