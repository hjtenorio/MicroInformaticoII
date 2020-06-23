import { createSelector } from 'reselect';
import { initialState } from './reducers';

const stolenAlertState = (state) => state.assets.stolenAlert || initialState;

const makeStolenAlertAddSubmitRequestedSelector = () => createSelector(stolenAlertState, (state) => state.stolenAlertAddSubmitRequested);

const makeStolenAlertAddSubmitSucceededSelector = () => createSelector(stolenAlertState, (state) => state.stolenAlertAddSubmitSucceeded);

const makeStolenAlertAddSubmitSucceededTicketNumberSelector = () => createSelector(stolenAlertState, (state) => state.stolenAlertAddSubmitSucceededTicketNumber);

const makeStolenAlertAddSubmitFailedSelector = () => createSelector(stolenAlertState, (state) => state.stolenAlertAddSubmitFailed);

export default stolenAlertState;

export { makeStolenAlertAddSubmitRequestedSelector, makeStolenAlertAddSubmitSucceededSelector, makeStolenAlertAddSubmitSucceededTicketNumberSelector, makeStolenAlertAddSubmitFailedSelector };
