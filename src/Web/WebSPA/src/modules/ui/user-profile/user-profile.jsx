/* eslint-disable react/prop-types */
/* eslint-disable jsx-a11y/click-events-have-key-events */
/* eslint-disable jsx-a11y/no-noninteractive-element-interactions */
import { Avatar, Popover } from 'antd';
import React from 'react';
import styled from '@emotion/styled';
import avatar from './avatar.jpg';

const Name = styled.div`
  color: #038fdd;
`;

const AvatarContainer = styled.div`
  width: 100%;
  margin-bottom: 4px;
`;

const UserProfile = ({ user, logout }) => {
  const userMenuOptions = (
    <ul className="gx-user-popover">
      <li
        onClick={() => {
          logout();
        }}
      >
        Cerrar Sesión
      </li>
    </ul>
  );

  return (
    <div className="gx-flex-row gx-align-items-center gx-mb-4 gx-avatar-row">
      <Popover
        placement="bottomRight"
        content={userMenuOptions}
        trigger="click"
      >
        <Avatar className="gx-size-40 gx-pointer gx-mb-2" src={avatar} />
        <div className="gx-avatar-name">
          <div>{user.firstName}</div>
          <div>{user.lastName}</div>
          <span className="gx-avatar-name">
            {`${user.email}`}
            <i className="icon icon-chevron-down gx-fs-xxs gx-ml-2" />
          </span>
        </div>
      </Popover>
    </div>
  );
};

export default UserProfile;

//  {/* <div css={{ textAlign: 'center' }}>

//       <Popover
//         placement="bottomRight"
//         content={userMenuOptions}
//         trigger="click"
//       >
//         <AvatarContainer />

//       </Popover>
//     </div> */}
