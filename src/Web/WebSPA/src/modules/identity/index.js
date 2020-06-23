import { IdentityContext, IdentityProvider, useIdentity } from './modules/core/hooks/useIdentity';
import ForgotPasswordPage from './modules/forgot-password/pages/forgot-password-page';
import LoginPage from './modules/login/pages/login-page';
import ResetPasswordPage from './modules/reset-password/pages/reset-password-page';
import * as actions from './store/actions';
import createReducer, { initialState } from './store/reducer';
import sagas from './store/sagas';
import * as selectors from './store/selectors';
import * as types from './store/types';

// import UserStaffTerminationInfoPage from './modules/staff-termination/pages/UserStaffTerminationInfoPage';

// pages
export { LoginPage };
export { ForgotPasswordPage };
export { ResetPasswordPage };
// export { UserStaffTerminationInfoPage };

// store
export { actions };
export { selectors };
export { types };
export { createReducer };
export { sagas };
export { initialState };

// hooks
export { useIdentity };
export { IdentityProvider };
export { IdentityContext };
