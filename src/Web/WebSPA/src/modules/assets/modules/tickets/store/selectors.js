import { createSelector } from 'reselect';

import { initialState } from './reducers';

const ticketState = (state) => state.assets.ticket || initialState;

/*
 * Ticket Paginated List
 */

const makeTicketPaginatedListSelector = () => createSelector(ticketState, (state) => state.ticketPaginatedList);
const makeTicketPaginatedListFetchRequestedSelector = () => createSelector(ticketState, (state) => state.ticketPaginatedListFetchRequested);
const makeTicketPaginatedListFetchSucceededSelector = () => createSelector(ticketState, (state) => state.ticketPaginatedListFetchSucceeded);
const makeTicketPaginatedListFetchFailedSelector = () => createSelector(ticketState, (state) => state.ticketPaginatedListFetchFailed);

export { makeTicketPaginatedListSelector };
export { makeTicketPaginatedListFetchRequestedSelector };
export { makeTicketPaginatedListFetchSucceededSelector };
export { makeTicketPaginatedListFetchFailedSelector };

/*
 * Ticket Add Submit
 */

const makeTicketAddSubmitRequestedSelector = () => createSelector(ticketState, (state) => state.ticketAddSubmitRequested);
const makeTicketAddSubmitSucceededSelector = () => createSelector(ticketState, (state) => state.ticketAddSubmitSucceeded);
const makeTicketAddSubmitSucceededTicketNumberSelector = () => createSelector(ticketState, (state) => state.ticketAddSubmitSucceededTicketNumber);
const makeTicketAddSubmitFailedSelector = () => createSelector(ticketState, (state) => state.ticketAddSubmitFailed);

/*
 * Ticket Add Submit
 */

const makeTicketDetailUpdateSubmitRequestedSelector = () => createSelector(ticketState, (state) => state.ticketDetailUpdateSubmitRequested);
const makeTicketDetailUpdateSubmitSucceededSelector = () => createSelector(ticketState, (state) => state.ticketDetailUpdateSubmitSucceeded);
const makeTicketDetailUpdateSubmitFailedSelector = () => createSelector(ticketState, (state) => state.ticketDetailUpdateSubmitFailed);

export { makeTicketDetailUpdateSubmitRequestedSelector };
export { makeTicketDetailUpdateSubmitSucceededSelector };
export { makeTicketDetailUpdateSubmitFailedSelector };

const makeUserTicketsPaginatedListSelector = () => createSelector(ticketState, (state) => state.userTicketsPaginatedList);
const makeUserTicketsPaginatedListFetchRequestedSelector = () => createSelector(ticketState, (state) => state.userTicketsPaginatedListFetchRequested);
const makeUserTicketsPaginatedListFetchSucceededSelector = () => createSelector(ticketState, (state) => state.userTicketsPaginatedListFetchSucceeded);
const makeUserTicketsPaginatedListFetchFailedSelector = () => createSelector(ticketState, (state) => state.userTicketsPaginatedListFetchFailed);

const makeUserTicketsPaginatedListFetchErrorSelector = () => createSelector(ticketState, (state) => state.userTicketsPaginatedListFetchError);

/*
 * Ticket Status List
 */

const makeTicketStatusListSelector = () => createSelector(ticketState, (state) => state.ticketStatusList);

const makeTicketStatusListFetchRequestedSelector = () => createSelector(ticketState, (state) => state.ticketStatusListFetchRequested);

const makeTicketStatusListFetchSucceededSelector = () => createSelector(ticketState, (state) => state.ticketStatusListFetchSucceeded);

const makeTicketStatusListFetchFailedSelector = () => createSelector(ticketState, (state) => state.ticketStatusListFetchFailed);

const makeTicketStatusListFetchErrorSelector = () => createSelector(ticketState, (state) => state.ticketStatusListFetchError);

const makeTicketStatusDataSelector = () => createSelector(ticketState, (state) => state.ticketStatusData);

const makeTicketStatusDataFetchRequestedSelector = () => createSelector(ticketState, (state) => state.ticketStatusDataFetchRequested);

const makeTicketStatusDataFetchSucceededSelector = () => createSelector(ticketState, (state) => state.ticketStatusDataFetchSucceeded);

const makeTicketStatusDataFetchFailedSelector = () => createSelector(ticketState, (state) => state.ticketStatusDataFetchFailed);

const makeTicketStatusDataFetchErrorMessageSelector = () => createSelector(ticketState, (state) => state.ticketStatusDataFetchErrorMessage);

const makeTicketDetailDataSelector = () => createSelector(ticketState, (state) => state.ticketDetailData);

const makeTicketDetailDataFetchRequestedSelector = () => createSelector(ticketState, (state) => state.ticketDetailDataFetchRequested);

const makeTicketDetailDataFetchSucceededSelector = () => createSelector(ticketState, (state) => state.ticketDetailDataFetchSucceeded);

const makeTicketDetailDataFetchFailedSelector = () => createSelector(ticketState, (state) => state.ticketDetailDataFetchFailed);

const makeTicketDetailDataFetchErrorMessageSelector = () => createSelector(ticketState, (state) => state.ticketDetailDataFetchErrorMessage);

const makeTicketQueueDetailDataSelector = () => createSelector(ticketState, (state) => state.ticketQueueDetailData);

const makeTicketQueueDetailDataFetchRequestedSelector = () => createSelector(ticketState, (state) => state.ticketQueueDetailDataFetchRequested);

const makeTicketQueueDetailDataFetchSucceededSelector = () => createSelector(ticketState, (state) => state.ticketQueueDetailDataFetchSucceeded);

const makeTicketQueueDetailDataFetchFailedSelector = () => createSelector(ticketState, (state) => state.ticketQueueDetailDataFetchFailed);

const makeTicketQueueDetailDataFetchErrorMessageSelector = () => createSelector(ticketState, (state) => state.ticketQueueDetailDataFetchErrorMessage);

const makeTicketServiceListSelector = () => createSelector(ticketState, (state) => state.ticketServiceList);

const makeTicketServiceListFetchRequestedSelector = () => createSelector(ticketState, (state) => state.ticketServiceListFetchRequested);

const makeTicketServiceListFetchSucceededSelector = () => createSelector(ticketState, (state) => state.ticketServiceListFetchSucceeded);

const makeTicketServiceListFetchFailedSelector = () => createSelector(ticketState, (state) => state.ticketServiceListFetchFailed);

const makeTicketServiceListFetchErrorMessageSelector = () => createSelector(ticketState, (state) => state.ticketServiceListFetchErrorMessage);

export default ticketState;

export {
  makeTicketAddSubmitRequestedSelector,
  makeTicketAddSubmitSucceededSelector,
  makeTicketAddSubmitSucceededTicketNumberSelector,
  makeTicketAddSubmitFailedSelector,
  makeUserTicketsPaginatedListSelector,
  makeUserTicketsPaginatedListFetchRequestedSelector,
  makeUserTicketsPaginatedListFetchSucceededSelector,
  makeUserTicketsPaginatedListFetchFailedSelector,
  makeUserTicketsPaginatedListFetchErrorSelector,
  makeTicketStatusListSelector,
  makeTicketStatusListFetchRequestedSelector,
  makeTicketStatusListFetchSucceededSelector,
  makeTicketStatusListFetchFailedSelector,
  makeTicketStatusListFetchErrorSelector,
  makeTicketStatusDataSelector,
  makeTicketStatusDataFetchRequestedSelector,
  makeTicketStatusDataFetchSucceededSelector,
  makeTicketStatusDataFetchFailedSelector,
  makeTicketStatusDataFetchErrorMessageSelector,
  makeTicketDetailDataSelector,
  makeTicketDetailDataFetchRequestedSelector,
  makeTicketDetailDataFetchSucceededSelector,
  makeTicketDetailDataFetchFailedSelector,
  makeTicketDetailDataFetchErrorMessageSelector,
  makeTicketQueueDetailDataSelector,
  makeTicketQueueDetailDataFetchRequestedSelector,
  makeTicketQueueDetailDataFetchSucceededSelector,
  makeTicketQueueDetailDataFetchFailedSelector,
  makeTicketQueueDetailDataFetchErrorMessageSelector,
  makeTicketServiceListSelector,
  makeTicketServiceListFetchRequestedSelector,
  makeTicketServiceListFetchSucceededSelector,
  makeTicketServiceListFetchFailedSelector,
  makeTicketServiceListFetchErrorMessageSelector,
};
