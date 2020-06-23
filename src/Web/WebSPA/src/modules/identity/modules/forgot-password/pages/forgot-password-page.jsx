/* eslint-disable no-use-before-define */
/* eslint-disable react/prop-types */

import { Spin, notification } from 'antd';
import React, { useEffect, useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { createStructuredSelector } from 'reselect';

import styled from '@emotion/styled';

import ForgotPasswordForm from '../components/forgo-passwod-form';
import {
  forgotPasswordPageEnter,
  forgotPasswordPageLeave,
  forgotPasswordRequested as forgotPasswordRequestedAction,
} from '../store/actions';
import {
  makeForgotPasswordFailedErrorSelector,
  makeForgotPasswordFailedSelector,
  makeForgotPasswordRequestedSelector,
  makeForgotPasswordSucceededSelector,
} from '../store/selectors';

const forgotPasswordStateSelector = createStructuredSelector({
  forgotPasswordRequested: makeForgotPasswordRequestedSelector(),
  forgotPasswordSucceeded: makeForgotPasswordSucceededSelector(),
  forgotPasswordFailed: makeForgotPasswordFailedSelector(),
  forgotPasswordFailedError: makeForgotPasswordFailedErrorSelector(),
});

const PageContainer = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  min-height: 100%;
`;

export default function ForgotPasswordPage() {
  const [loading, setLoading] = useState(false);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(forgotPasswordPageEnter());

    return function cleanup() {
      dispatch(forgotPasswordPageLeave());
    };
  }, []);

  const {
    forgotPasswordRequested,
    forgotPasswordSucceeded,
    forgotPasswordFailed,
    forgotPasswordFailedError,
  } = useSelector(forgotPasswordStateSelector);

  useEffect(() => {
    if (forgotPasswordRequested) {
      setLoading(true);
    }
  }, [forgotPasswordRequested]);

  useEffect(() => {
    setLoading(false);

    if (forgotPasswordSucceeded) {
      notification.success({
        message:
          'Se ha enviado un mensaje a su correo electronico para reestablecer su contrasena',
        duration: 5,
        placement: 'bottomRight',
      });
    }
    if (forgotPasswordFailed) {
      notification.error({
        message: forgotPasswordFailedError,
        duration: 5,
        placement: 'bottomRight',
      });
    }
  }, [forgotPasswordSucceeded, forgotPasswordFailed]);

  function submit(event) {
    const { dni } = event;
    dispatch(forgotPasswordRequestedAction(dni));
  }

  function showNotification(type, message) {
    switch (type) {
      case 'success':
        break;
      case 'error':
        notification.error({
          message,
          duration: 5,
          placement: 'bottomRight',
        });
        break;
      default:
        break;
    }
  }

  return (
    <PageContainer>
      <Spin spinning={loading}>
        <ForgotPasswordForm submit={submit} />
      </Spin>
    </PageContainer>
  );
}
