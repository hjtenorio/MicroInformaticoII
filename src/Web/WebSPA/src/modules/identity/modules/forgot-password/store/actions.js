import {
  FORGOT_PASSWORD_REQUESTED,
  FORGOT_PASSWORD_SUCCEEDED,
  FORGOT_PASSWORD_FAILED,
  FORGOT_PASSWORD_PAGE_ENTER,
  FORGOT_PASSWORD_PAGE_LEAVE,
} from './types';

function forgotPasswordRequested(dni) {
  return {
    type: FORGOT_PASSWORD_REQUESTED,
    dni,
  };
}

function forgotPasswordSucceeded(response) {
  return {
    type: FORGOT_PASSWORD_SUCCEEDED,
    response,
  };
}

function forgotPasswordFailed(error) {
  return {
    type: FORGOT_PASSWORD_FAILED,
    error,
  };
}

function forgotPasswordPageEnter() {
  return {
    type: FORGOT_PASSWORD_PAGE_ENTER,
  };
}

function forgotPasswordPageLeave() {
  return {
    type: FORGOT_PASSWORD_PAGE_LEAVE,
  };
}

export { forgotPasswordRequested };
export { forgotPasswordSucceeded };
export { forgotPasswordFailed };
export { forgotPasswordPageEnter };
export { forgotPasswordPageLeave };
