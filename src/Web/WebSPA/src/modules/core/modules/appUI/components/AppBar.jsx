/* eslint-disable jsx-a11y/click-events-have-key-events */
/* eslint-disable jsx-a11y/no-static-element-interactions */

import React from 'react';

import { useIdentity } from '@valtx-mi2/identity';
import { Header as BaseHeader, Theme, ValtxLogo } from '@valtx-mi2/ui';

import { useApplicationUI } from '../hooks/useApplicationUI';

const {
  NAV_STYLE_FIXED,
  NAV_STYLE_MINI_SIDEBAR,
  NAV_STYLE_DRAWER,
  TAB_SIZE,
} = Theme.constants;

// eslint-disable-next-line react/prop-types
export default function AppBar({ children }) {
  const applicationUI = useApplicationUI();
  const identity = useIdentity();

  const { navStyle, onToggleSidebarCollapsed, width } = applicationUI;

  if (!identity) {
    console.log('Identity not found');
    return null;
  }

  if (!identity.isAuthenticated) {
    return null;
  }

  return (
    <>
      {navStyle === NAV_STYLE_DRAWER ||
      ((navStyle === NAV_STYLE_FIXED || navStyle === NAV_STYLE_MINI_SIDEBAR) &&
        width < TAB_SIZE) ? (
        <BaseHeader
          css={{
            position: 'fixed',
            zIndex: 1,
            width: '100%',
            backgroundColor: '#036',
            paddingRight: '5px',
          }}
        >
          <ValtxLogo height="22" type="white" />
          <div className="gx-linebar">
            <i
              className="gx-icon-btn icon icon-menu gx-text-white"
              onClick={() => {
                onToggleSidebarCollapsed();
              }}
            />
          </div>
        </BaseHeader>
      ) : null}
    </>
  );
}

// <i
//           className={`gx-icon-btn icon icon-${
//             navStyle === NAV_STYLE_MINI_SIDEBAR ? 'menu-unfold' : 'menu-fold'
//           } ${themeType !== THEME_TYPE_LITE ? 'gx-text-white' : ''}`}
//           onClick={() => {
//             if (navStyle === NAV_STYLE_DRAWER) {
//               onToggleSidebarCollapsed();
//             } else if (navStyle === NAV_STYLE_FIXED) { //               onSetNavStyle(NAV_STYLE_MINI_SIDE) { -iconelse if (navStyle === NAV_STYLE_NO_HEADER_MINI_SIDEBAR) === NAV_STYLE_MINI_SIDEBAR ? 'menu-unfold' : 'menu-fold'} ${themeType !== THEME_TYPE_LITE ? 'gx-text-white' : ''}`}
//               onToggleSidebarCollapseddark else {
//               onSetNavStyle(NAV_STYLE_FIXED);
//             }
//           }}
//         />
