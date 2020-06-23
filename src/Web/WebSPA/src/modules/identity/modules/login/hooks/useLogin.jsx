import { useState, useEffect } from 'react';
import { createStructuredSelector } from 'reselect';
import { useSelector, useDispatch } from 'react-redux';
import { userLoginAction } from '../store/actions';
import {
  makeUserLoginRequestedSelector,
  makeUserLoginSucceededSelector,
  makeUserLoginFailedSelector,
  makeUserSelector,
  makeUserLoginFailedErrorMessageSelector,
} from '../store/selectors';

function useLogin() {
  const dispatch = useDispatch();
  const {
    userLoginRequested,
    userLoginSucceeded,
    userLoginFailed,
    userLoginFailedErrorMessage,
    user,
  } = useSelector(
    createStructuredSelector({
      userLoginRequested: makeUserLoginRequestedSelector(),
      userLoginSucceeded: makeUserLoginSucceededSelector(),
      userLoginFailed: makeUserLoginFailedSelector(),
      user: makeUserSelector(),
      userLoginFailedErrorMessage: makeUserLoginFailedErrorMessageSelector(),
    })
  );

  function loginSubmit(username, password) {
    dispatch(userLoginAction(username, password));
  }

  return {
    loginUser: user,
    loginSubmit,
    loginSubmitRequested: userLoginRequested,
    loginSubmitSucceeded: userLoginSucceeded,
    loginSubmitFailed: userLoginFailed,
    loginSubmitFailedErrorMessage: userLoginFailedErrorMessage,
  };
}

export default useLogin;
