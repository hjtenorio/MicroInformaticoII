import {
  TICKET_STATUS_LIST_FETCH,
  TICKET_STATUS_LIST_FETCH_REQUESTED,
  TICKET_STATUS_LIST_FETCH_SUCCEEDED,
  TICKET_STATUS_LIST_FETCH_FAILED,
  TICKET_ADD_SUBMIT,
  TICKET_ADD_SUBMIT_FAILED,
  TICKET_ADD_SUBMIT_REQUESTED,
  TICKET_ADD_SUBMIT_SUCCEEDED,
  TICKET_PAGINATED_LIST_FETCH,
  TICKET_PAGINATED_LIST_FETCH_FAILED,
  TICKET_PAGINATED_LIST_FETCH_REQUESTED,
  TICKET_PAGINATED_LIST_FETCH_SUCCEEDED,
  USER_TICKETS_PAGINATED_LIST_FETCH,
  USER_TICKETS_PAGINATED_LIST_FETCH_FAILED,
  USER_TICKETS_PAGINATED_LIST_FETCH_REQUESTED,
  USER_TICKETS_PAGINATED_LIST_FETCH_SUCCEEDED,
  TICKET_SERVICE_LIST_FETCH,
  TICKET_SERVICE_LIST_FETCH_FAILED,
  TICKET_SERVICE_LIST_FETCH_REQUESTED,
  TICKET_SERVICE_LIST_FETCH_SUCCEEDED,
  USER_TICKETS_SERVICE_LIST_FETCH,
  USER_TICKETS_SERVICE_LIST_FETCH_FAILED,
  USER_TICKETS_SERVICE_LIST_FETCH_REQUESTED,
  USER_TICKETS_SERVICE_LIST_FETCH_SUCCEEDED,
  USER_TICKETS_STATUS_LIST_FETCH,
  USER_TICKETS_STATUS_LIST_FETCH_FAILED,
  USER_TICKETS_STATUS_LIST_FETCH_REQUESTED,
  USER_TICKETS_STATUS_LIST_FETCH_SUCCEEDED,
  TICKET_STATUS_DATA_FETCH,
  TICKET_STATUS_DATA_FETCH_REQUESTED,
  TICKET_STATUS_DATA_FETCH_SUCCEEDED,
  TICKET_STATUS_DATA_FETCH_FAILED,
  TICKET_DETAIL_DATA_FETCH,
  TICKET_DETAIL_DATA_FETCH_REQUESTED,
  TICKET_DETAIL_DATA_FETCH_SUCCEEDED,
  TICKET_DETAIL_DATA_FETCH_FAILED,
  TICKET_QUEUE_DETAIL_DATA_FETCH,
  TICKET_QUEUE_DETAIL_DATA_FETCH_REQUESTED,
  TICKET_QUEUE_DETAIL_DATA_FETCH_SUCCEEDED,
  TICKET_QUEUE_DETAIL_DATA_FETCH_FAILED,
  TICKET_DETAIL_UPDATE_SUBMIT,
  TICKET_DETAIL_UPDATE_SUBMIT_REQUESTED,
  TICKET_DETAIL_UPDATE_SUBMIT_SUCCEEDED,
  TICKET_DETAIL_UPDATE_SUBMIT_FAILED,
} from './types';

/*
 * Ticket Paginated List Fetch
 */

function ticketPaginatedListFetchAction(params, currentPage, pageSize, identity) {
  return {
    type: TICKET_PAGINATED_LIST_FETCH,
    params,
    currentPage,
    pageSize,
    identity,
  };
}

function ticketPaginatedListFetchRequestedAction() {
  return {
    type: TICKET_PAGINATED_LIST_FETCH_REQUESTED,
  };
}

function ticketPaginatedListFetchSucceededAction(paginatedList) {
  return {
    type: TICKET_PAGINATED_LIST_FETCH_SUCCEEDED,
    paginatedList,
  };
}

function ticketPaginatedListFetchFailedAction(error) {
  return {
    type: TICKET_PAGINATED_LIST_FETCH_FAILED,
    error,
  };
}

export { ticketPaginatedListFetchAction };
export { ticketPaginatedListFetchRequestedAction };
export { ticketPaginatedListFetchSucceededAction };
export { ticketPaginatedListFetchFailedAction };

/*
 * Ticket Detail Update Submit
 */

function ticketDetailUpdateSubmitAction(params, identity) {
  return {
    type: TICKET_DETAIL_UPDATE_SUBMIT,
    params,
    identity,
  };
}

function ticketDetailUpdateSubmitRequestedAction() {
  return {
    type: TICKET_DETAIL_UPDATE_SUBMIT_REQUESTED,
  };
}

function ticketDetailUpdateSubmitSucceededAction() {
  return {
    type: TICKET_DETAIL_UPDATE_SUBMIT_SUCCEEDED,
  };
}

function ticketDetailUpdateSubmitFailedAction(error) {
  return {
    type: TICKET_DETAIL_UPDATE_SUBMIT_FAILED,
    error,
  };
}

export { ticketDetailUpdateSubmitAction };
export { ticketDetailUpdateSubmitRequestedAction };
export { ticketDetailUpdateSubmitSucceededAction };
export { ticketDetailUpdateSubmitFailedAction };

/*
 * Ticket Status List Fetch
 */
function ticketStatusListFetchAction(identity) {
  return {
    type: TICKET_STATUS_LIST_FETCH,
    identity,
  };
}

function ticketStatusListFetchRequestedAction() {
  return {
    type: TICKET_STATUS_LIST_FETCH_REQUESTED,
  };
}

function ticketStatusListFetchSucceededAction(ticketStatusList) {
  return {
    type: TICKET_STATUS_LIST_FETCH_SUCCEEDED,
    ticketStatusList,
  };
}

function ticketStatusListFetchFailedAction(error) {
  return {
    type: TICKET_STATUS_LIST_FETCH_FAILED,
    error,
  };
}

export { ticketStatusListFetchAction };
export { ticketStatusListFetchRequestedAction };
export { ticketStatusListFetchSucceededAction };
export { ticketStatusListFetchFailedAction };

function ticketAddSubmitAction(params, identity) {
  return {
    type: TICKET_ADD_SUBMIT,
    params,
    identity,
  };
}

function ticketAddSubmitRequestedAction() {
  return {
    type: TICKET_ADD_SUBMIT_REQUESTED,
  };
}

function ticketAddSubmitSucceededAction(ticketCreatedNumber) {
  return {
    type: TICKET_ADD_SUBMIT_SUCCEEDED,
    ticketCreatedNumber,
  };
}

function ticketAddSubmitFailedAction(error) {
  return {
    type: TICKET_ADD_SUBMIT_FAILED,
    error,
  };
}

function userTicketsPaginatedListFetchAction(identity, nroDni, searchParams, currentPage, pageSize) {
  return {
    type: USER_TICKETS_PAGINATED_LIST_FETCH,
    identity,
    nroDni,
    searchParams,
    currentPage,
    pageSize,
  };
}

function userTicketsPaginatedListFetchRequestedAction() {
  return {
    type: USER_TICKETS_PAGINATED_LIST_FETCH_REQUESTED,
  };
}

function userTicketsPaginatedListFetchSucceededAction(data) {
  return {
    type: USER_TICKETS_PAGINATED_LIST_FETCH_SUCCEEDED,
    data,
  };
}

function userTicketsPaginatedListFetchFailedAction(error) {
  return {
    type: USER_TICKETS_PAGINATED_LIST_FETCH_FAILED,
    error,
  };
}

function userTicketsServiceListFetchAction(identity) {
  return {
    type: USER_TICKETS_SERVICE_LIST_FETCH,
    identity,
  };
}

function userTicketsServiceListFetchRequestedAction() {
  return {
    type: USER_TICKETS_SERVICE_LIST_FETCH_REQUESTED,
  };
}

function userTicketsServiceListFetchSucceededAction(data) {
  return {
    type: USER_TICKETS_SERVICE_LIST_FETCH_SUCCEEDED,
    data,
  };
}

function userTicketsServiceListFetchFailedAction(error) {
  return {
    type: USER_TICKETS_SERVICE_LIST_FETCH_FAILED,
    error,
  };
}

function userTicketsStatusListFetchAction(identity) {
  return {
    type: USER_TICKETS_STATUS_LIST_FETCH,
    identity,
  };
}

function userTicketsStatusListFetchRequestedAction() {
  return {
    type: USER_TICKETS_STATUS_LIST_FETCH_REQUESTED,
  };
}

function userTicketsStatusListFetchSucceededAction(data) {
  return {
    type: USER_TICKETS_STATUS_LIST_FETCH_SUCCEEDED,
    data,
  };
}

function userTicketsStatusListFetchFailedAction(error) {
  return {
    type: USER_TICKETS_STATUS_LIST_FETCH_FAILED,
    error,
  };
}

function ticketStatusDataFetchAction(identity, ticketId) {
  return {
    type: TICKET_STATUS_DATA_FETCH,
    identity,
    ticketId,
  };
}

function ticketStatusDataFetchRequestedAction() {
  return {
    type: TICKET_STATUS_DATA_FETCH_REQUESTED,
  };
}

function ticketStatusDataFetchSucceededAction(data) {
  return {
    type: TICKET_STATUS_DATA_FETCH_SUCCEEDED,
    data,
  };
}

function ticketStatusDataFetchFailedAction(error) {
  return {
    type: TICKET_STATUS_DATA_FETCH_FAILED,
    error,
  };
}

function ticketDetailDataFetchAction(identity, ticketId) {
  return {
    type: TICKET_DETAIL_DATA_FETCH,
    identity,
    ticketId,
  };
}

function ticketDetailDataFetchRequestedAction() {
  return {
    type: TICKET_DETAIL_DATA_FETCH_REQUESTED,
  };
}

function ticketDetailDataFetchSucceededAction(data) {
  return {
    type: TICKET_DETAIL_DATA_FETCH_SUCCEEDED,
    data,
  };
}

function ticketDetailDataFetchFailedAction(error) {
  return {
    type: TICKET_DETAIL_DATA_FETCH_FAILED,
    error,
  };
}

function ticketQueueDetailDataFetchAction(identity, ticketId, queue) {
  return {
    type: TICKET_QUEUE_DETAIL_DATA_FETCH,
    identity,
    ticketId,
    queue,
  };
}

function ticketQueueDetailDataFetchRequestedAction() {
  return {
    type: TICKET_QUEUE_DETAIL_DATA_FETCH_REQUESTED,
  };
}

function ticketQueueDetailDataFetchSucceededAction(data) {
  return {
    type: TICKET_QUEUE_DETAIL_DATA_FETCH_SUCCEEDED,
    data,
  };
}

function ticketQueueDetailDataFetchFailedAction(error) {
  return {
    type: TICKET_QUEUE_DETAIL_DATA_FETCH_FAILED,
    error,
  };
}

function ticketServiceListFetchAction(identity) {
  return {
    type: TICKET_SERVICE_LIST_FETCH,
    identity,
  };
}

function ticketServiceListFetchRequestedAction() {
  return {
    type: TICKET_SERVICE_LIST_FETCH_REQUESTED,
  };
}

function ticketServiceListFetchSucceededAction(data) {
  return {
    type: TICKET_SERVICE_LIST_FETCH_SUCCEEDED,
    data,
  };
}

function ticketServiceListFetchFailedAction(error) {
  return {
    type: TICKET_SERVICE_LIST_FETCH_FAILED,
    error,
  };
}

export {
  ticketAddSubmitAction,
  ticketAddSubmitRequestedAction,
  ticketAddSubmitSucceededAction,
  ticketAddSubmitFailedAction,
  userTicketsPaginatedListFetchAction,
  userTicketsPaginatedListFetchRequestedAction,
  userTicketsPaginatedListFetchSucceededAction,
  userTicketsPaginatedListFetchFailedAction,
  userTicketsServiceListFetchAction,
  userTicketsServiceListFetchRequestedAction,
  userTicketsServiceListFetchSucceededAction,
  userTicketsServiceListFetchFailedAction,
  userTicketsStatusListFetchAction,
  userTicketsStatusListFetchRequestedAction,
  userTicketsStatusListFetchSucceededAction,
  userTicketsStatusListFetchFailedAction,
  ticketStatusDataFetchAction,
  ticketStatusDataFetchRequestedAction,
  ticketStatusDataFetchSucceededAction,
  ticketStatusDataFetchFailedAction,
  ticketDetailDataFetchAction,
  ticketDetailDataFetchRequestedAction,
  ticketDetailDataFetchSucceededAction,
  ticketDetailDataFetchFailedAction,
  ticketQueueDetailDataFetchAction,
  ticketQueueDetailDataFetchRequestedAction,
  ticketQueueDetailDataFetchSucceededAction,
  ticketQueueDetailDataFetchFailedAction,
  ticketServiceListFetchAction,
  ticketServiceListFetchRequestedAction,
  ticketServiceListFetchSucceededAction,
  ticketServiceListFetchFailedAction,
};
