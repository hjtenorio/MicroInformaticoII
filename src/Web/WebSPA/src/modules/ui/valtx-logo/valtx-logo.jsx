/* eslint-disable jsx-a11y/alt-text */

import React from 'react';

import ValtxLogoWhiteSVG from './valtx-logo-white.svg';
import ValtxLogoSVG from './valtx-logo.svg';

export default function ValtxLogo({ type, ...rest }) {
  // eslint-disable-next-line react/jsx-props-no-spreading
  if (type === 'white') return <img {...rest} src={ValtxLogoWhiteSVG} />;
  // eslint-disable-next-line react/jsx-props-no-spreading
  return <img {...rest} src={ValtxLogoSVG} />;
}
