import React from 'react';

import TicketAssetsTable from './TicketAssetsTable';

export default function TicketAssetSelect(
  assetsListFetchRequested,
  assetsList,
  onChange,
  value
) {
  const handleAssetIdChange = (asset) => {
    console.log('handleAssetIdChange', asset);
    // eslint-disable-next-line no-use-before-define
    triggerChange(asset);
  };

  const triggerChange = (changedValue) => {
    if (onChange) {
      onChange({
        ...value,
        ...changedValue,
      });
    }
  };
  return (
    <TicketAssetsTable
      loading={assetsListFetchRequested}
      data={assetsList}
      onChange={(asset) => handleAssetIdChange(asset)}
      value={value}
    />
  );
}
