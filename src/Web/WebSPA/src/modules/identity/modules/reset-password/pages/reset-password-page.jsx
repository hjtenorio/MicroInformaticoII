import { notification, Spin } from 'antd';

import React, { useState, useEffect } from 'react';

import { createStructuredSelector } from 'reselect';
import { useDispatch, useSelector } from 'react-redux';
import { useHistory, useParams } from 'react-router-dom';
import styled from '@emotion/styled';
import { Layout } from '@valtx-mi2/ui';
import {
  makeResetPasswordRequestedSelector,
  makeResetPasswordSucceededSelector,
  makeResetPasswordFailedSelector,
  makeResetPasswordFailedErrorSelector,
} from '../store/selectors';

import { resetPasswordRequested as resetPasswordRequestedAction } from '../store/actions';
import ResetPasswordForm from '../components/reset-password-form';

const stateSelector = createStructuredSelector({
  resetPasswordRequested: makeResetPasswordRequestedSelector(),
  resetPasswordSucceeded: makeResetPasswordSucceededSelector(),
  resetPasswordFailed: makeResetPasswordFailedSelector(),
  resetPasswordFailedError: makeResetPasswordFailedErrorSelector(),
});

const PageContainer = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  min-height: 100%;
`;

export default function ResetPasswordPage() {
  const dispatch = useDispatch();
  const history = useHistory();
  const { token } = useParams();

  const {
    resetPasswordRequested,
    resetPasswordSucceeded,
    resetPasswordFailed,
    resetPasswordFailedError,
  } = useSelector(stateSelector);

  const [loading, setLoading] = useState(false);

  useEffect(() => {
    if (resetPasswordRequested) setLoading(true);
  }, [resetPasswordRequested]);

  useEffect(() => {
    if (resetPasswordSucceeded) {
      setLoading(false);
      notification.success({
        message: 'La contraseña se reestableció satisfactoriamente',
        duration: 5,
        placement: 'bottomRight',
      });
      history.push('/identity/login');
    }
  }, [resetPasswordSucceeded]);

  useEffect(() => {
    if (resetPasswordFailed) {
      setLoading(false);
      notification.error({
        message: resetPasswordFailedError,
        duration: 5,
        placement: 'bottomRight',
      });
    }
  });

  function submit(event) {
    const { password } = event;
    dispatch(resetPasswordRequestedAction(token, password));
  }

  return (
    <PageContainer>
      <Spin spinning={loading}>
        <ResetPasswordForm submit={submit} />
      </Spin>
    </PageContainer>
  );
}
