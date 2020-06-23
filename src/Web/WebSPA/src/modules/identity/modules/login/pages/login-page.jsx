/* eslint-disable no-use-before-define */

import { notification } from 'antd';
import { push } from 'connected-react-router';
import React, { useEffect } from 'react';
import { useDispatch } from 'react-redux';

import { css } from '@emotion/core';
import { Content, Layout, Spin, ValtxLogo } from '@valtx-mi2/ui';

import { useIdentity } from '../../core/hooks/useIdentity';
import LoginForm from '../components/login-form';
import useLogin from '../hooks/useLogin';

const layoutContent = css({
  display: 'flex',
  flexDirection: 'column',
  justifyContent: 'center',
});

const LoginPage = () => {
  const dispatch = useDispatch();
  const { isAuthenticated } = useIdentity();

  if (isAuthenticated) {
    dispatch(push('/home'));
  }

  const {
    loginSubmit,
    loginSubmitRequested,
    loginSubmitSucceeded,
    loginSubmitFailed,
    loginSubmitFailedErrorMessage,
  } = useLogin();

  useEffect(() => {
    if (loginSubmitSucceeded) {
      onLoginSubmitSucceeded();
    }

    if (loginSubmitFailed) {
      onLoginSubmitFailed();
    }
  }, [loginSubmitSucceeded, loginSubmitFailed]);

  function onLoginSubmit(values) {
    const { username, password } = values;
    loginSubmit(username, password);
  }

  function onLoginSubmitSucceeded() {
    dispatch(push('/home'));
  }

  function onLoginSubmitFailed() {
    notification.error({
      message: loginSubmitFailedErrorMessage,
      duration: 3,
      placement: 'bottomRight',
    });
  }

  return (
    <Layout css={{ height: '100%' }}>
      <Content css={layoutContent}>
        <div className="gx-app-login-wrap">
          <div className="gx-app-login-container">
            <div className="gx-app-login-main-content">
              <div
                className="gx-app-logo-content"
                css={{
                  'background-color': '#003366',
                }}
              >
                <div className="gx-app-logo-content-bg">
                  {/* <img src="https://via.placeholder.com/272x395" alt="Neature" /> */}
                </div>
                <div className="gx-app-logo-wid">
                  <h1>Iniciar Sesión</h1>
                </div>
                <div className="gx-app-logo">
                  <ValtxLogo type="white" />
                </div>
              </div>
              <div className="gx-app-login-content">
                <Spin spinning={loginSubmitRequested}>
                  <LoginForm
                    loading={loginSubmitRequested}
                    submit={onLoginSubmit}
                    forgotPassword={() =>
                      dispatch(push('/identity/forgot-password'))
                    }
                  />
                </Spin>
              </div>
              {/* {error ? message.error(errorMessage.toString()) : null} */}
            </div>
          </div>
        </div>
      </Content>
    </Layout>
  );
};

export default LoginPage;
