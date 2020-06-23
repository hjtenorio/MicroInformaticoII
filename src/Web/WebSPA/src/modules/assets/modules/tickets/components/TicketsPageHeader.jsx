import React from 'react';

import { PageHeader } from '@valtx-mi2/core';
import { Icon, SVGIcons } from '@valtx-mi2/ui';

const { TicketIcon } = SVGIcons;

export default function TicketsPageHeader() {
  return (
    <PageHeader>
      <Icon component={TicketIcon} /> Mis Tickets
    </PageHeader>
  );
}
