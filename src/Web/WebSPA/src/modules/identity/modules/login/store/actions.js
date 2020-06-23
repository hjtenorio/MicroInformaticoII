import { USER_LOGIN, USER_LOGIN_FAILED, USER_LOGIN_REQUESTED, USER_LOGIN_SUCCEEDED, USER_LOGOUT } from './types';

function userLoginAction(username, password) {
  return {
    type: USER_LOGIN,
    username,
    password,
  };
}

function userLoginRequestedAction() {
  return {
    type: USER_LOGIN_REQUESTED,
  };
}

function userLoginSucceededAction(user, token, menu) {
  return {
    type: USER_LOGIN_SUCCEEDED,
    user,
    token,
    menu,
  };
}

function userLoginFailedAction(error) {
  return {
    type: USER_LOGIN_FAILED,
    error,
  };
}

function userLogoutAction() {
  return {
    type: USER_LOGOUT,
  };
}

export { userLoginAction };
export { userLoginRequestedAction };
export { userLoginSucceededAction };
export { userLoginFailedAction };
export { userLogoutAction };
