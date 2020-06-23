import React from 'react';

import { createStructuredSelector } from 'reselect';
import * as forgotPasswordSelectors from '../store/selectors';

const {
  makeForgotPasswordRequestedSelector,
  makeForgotPasswordSucceededSelector,
  makeForgotPasswordFailedSelector,
} = forgotPasswordSelectors;

const useForgotPasswordState = createStructuredSelector({
  forgotPasswordRequested: makeForgotPasswordRequestedSelector(),
  forgotPasswordSucceeded: makeForgotPasswordSucceededSelector(),
  forgotPasswordFailed = makeForgotPasswordFailedSelector(),
});

export default function UseForgotPassword() {
  return <div />;
}
