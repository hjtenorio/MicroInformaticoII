import {
  RESET_PASSWORD_REQUESTED,
  RESET_PASSWORD_SUCCEEDED,
  RESET_PASSWORD_FAILED,
} from './types';

function resetPasswordRequested(token, password) {
  return {
    type: RESET_PASSWORD_REQUESTED,
    token,
    password,
  };
}

function resetPasswordSucceeded(response) {
  return {
    type: RESET_PASSWORD_SUCCEEDED,
    response,
  };
}

function resetPasswordFailed(error) {
  return {
    type: RESET_PASSWORD_FAILED,
    error,
  };
}

export { resetPasswordRequested };
export { resetPasswordSucceeded };
export { resetPasswordFailed };
