/* eslint-disable no-case-declarations */
/* eslint-disable default-case */
/* eslint-disable no-param-reassign */

import { LOCATION_CHANGE } from 'connected-react-router';
import produce, { setAutoFreeze } from 'immer';
import localForage from 'localforage';
import { persistReducer } from 'redux-persist';

import {
  TICKET_ADD_SUBMIT,
  TICKET_ADD_SUBMIT_FAILED,
  TICKET_ADD_SUBMIT_REQUESTED,
  TICKET_ADD_SUBMIT_SUCCEEDED,
  TICKET_DETAIL_UPDATE_SUBMIT,
  TICKET_DETAIL_UPDATE_SUBMIT_FAILED,
  TICKET_DETAIL_UPDATE_SUBMIT_REQUESTED,
  TICKET_DETAIL_UPDATE_SUBMIT_SUCCEEDED,
  TICKET_STATUS_LIST_FETCH,
  TICKET_STATUS_LIST_FETCH_FAILED,
  TICKET_STATUS_LIST_FETCH_REQUESTED,
  TICKET_STATUS_LIST_FETCH_SUCCEEDED,
  USER_TICKETS_PAGINATED_LIST_FETCH,
  USER_TICKETS_PAGINATED_LIST_FETCH_FAILED,
  USER_TICKETS_PAGINATED_LIST_FETCH_REQUESTED,
  USER_TICKETS_PAGINATED_LIST_FETCH_SUCCEEDED,
  TICKET_PAGINATED_LIST_FETCH,
  TICKET_PAGINATED_LIST_FETCH_FAILED,
  TICKET_PAGINATED_LIST_FETCH_REQUESTED,
  TICKET_PAGINATED_LIST_FETCH_SUCCEEDED,
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
  TICKET_SERVICE_LIST_FETCH,
  TICKET_SERVICE_LIST_FETCH_REQUESTED,
  TICKET_SERVICE_LIST_FETCH_SUCCEEDED,
  TICKET_SERVICE_LIST_FETCH_FAILED,
} from './types';

const initialState = {
  ticketAddSubmitRequested: false,
  ticketAddSubmitSucceeded: false,
  ticketAddSubmitSucceededTicketNumber: null,
  ticketAddSubmitFailed: false,

  ticketDetailUpdateSubmitRequested: false,
  ticketDetailUpdateSubmitSucceeded: false,
  ticketDetailUpdateSubmitFailed: false,

  userTicketsPaginatedList: [],
  userTicketsPaginatedListFetchRequested: false,
  userTicketsPaginatedListFetchSucceeded: false,
  userTicketsPaginatedListFetchFailed: false,
  userTicketsPaginatedListFetchError: null,
  userTicketsServiceList: [],
  userTicketsServiceListFetchRequested: false,
  userTicketsServiceListFetchSucceeded: false,
  userTicketsServiceListFetchFailed: false,
  userTicketsServiceListFetchError: null,
  ticketStatusList: [],
  ticketStatusListFetchRequested: false,
  ticketStatusListFetchSucceeded: false,
  ticketStatusListFetchFailed: false,
  ticketStatusListFetchError: null,
  ticketStatusData: [],
  ticketStatusDataFetchRequested: false,
  ticketStatusDataFetchSucceeded: false,
  ticketStatusDataFetchFailed: false,
  ticketStatusDataFetchErrorMessage: null,
  ticketDetailData: {},
  ticketDetailDataFetchRequested: false,
  ticketDetailDataFetchSucceeded: false,
  ticketDetailDataFetchFailed: false,
  ticketDetailDataFetchErrorMessage: null,
  ticketQueueDetailData: {},
  ticketQueueDetailDataFetchRequested: false,
  ticketQueueDetailDataFetchSucceeded: false,
  ticketQueueDetailDataFetchFailed: false,
  ticketQueueDetailDataFetchErrorMessage: null,
  ticketServiceListFetchRequested: false,
  ticketServiceListFetchSucceeded: false,
  ticketServiceListFetchFailed: false,
  ticketServiceListFetchFailedErrorMessage: null,
  ticketServiceList: [],
};

const persistConfig = {
  key: 'assets.tickets',
  storage: localForage,
  blacklist: [
    'ticketAddSubmitRequested',
    'ticketAddSubmitSucceeded',
    'ticketAddSubmitSucceededTicketNumber',
    'ticketAddSubmitFailed',
    'ticketDetailUpdateSubmitRequested',
    'ticketDetailUpdateSubmitSucceeded',
    'ticketDetailUpdateSubmitFailed',
    'userTicketsPaginatedList',
    'userTicketsPaginatedListFetchRequested',
    'userTicketsPaginatedListFetchSucceeded',
    'userTicketsPaginatedListFetchFailed',
    'userTicketsPaginatedListFetchError',
    'userTicketsServiceList',
    'userTicketsServiceListFetchRequested',
    'userTicketsServiceListFetchSucceeded',
    'userTicketsServiceListFetchFailed',
    'userTicketsServiceListFetchError',
    'ticketStatusList',
    'ticketStatusListFetchRequested',
    'ticketStatusListFetchSucceeded',
    'ticketStatusListFetchFailed',
    'ticketStatusListFetchError',
    'ticketStatusData',
    'ticketStatusDataFetchRequested',
    'ticketStatusDataFetchSucceeded',
    'ticketStatusDataFetchFailed',
    'ticketStatusDataFetchErrorMessage',
    'ticketDetailData',
    'ticketDetailDataFetchRequested',
    'ticketDetailDataFetchSucceeded',
    'ticketDetailDataFetchFailed',
    'ticketDetailDataFetchErrorMessage',
    'ticketQueueDetailData',
    'ticketQueueDetailDataFetchRequested',
    'ticketQueueDetailDataFetchSucceeded',
    'ticketQueueDetailDataFetchFailed',
    'ticketQueueDetailDataFetchErrorMessage',
    'ticketServiceListFetchRequested',
    'ticketServiceListFetchSucceeded',
    'ticketServiceListFetchFailed',
    'ticketServiceListFetchFailedErrorMessage',
    'ticketServiceList',
  ],
};

setAutoFreeze(false);

const reducer = produce((draft, action) => {
  switch (action.type) {
    /*
     * TICKET_ADD_SUBMIT
     */

    case TICKET_ADD_SUBMIT:
      draft.ticketAddSubmitRequested = false;
      draft.ticketAddSubmitSucceeded = false;
      draft.ticketAddSubmitSucceededTicketNumber = null;
      draft.ticketAddSubmitFailed = false;
      break;

    case TICKET_ADD_SUBMIT_REQUESTED:
      draft.ticketAddSubmitRequested = true;
      break;

    case TICKET_ADD_SUBMIT_SUCCEEDED:
      draft.ticketAddSubmitSucceededTicketNumber = action.ticketCreatedNumber;
      draft.ticketAddSubmitRequested = false;
      draft.ticketAddSubmitSucceeded = true;
      break;

    case TICKET_ADD_SUBMIT_FAILED:
      draft.ticketAddSubmitRequested = false;
      draft.ticketAddSubmitFailed = true;
      break;

    /*
     * TICKET_DETAIL_UPDATE_SUBMIT
     */

    case TICKET_DETAIL_UPDATE_SUBMIT:
      draft.ticketDetailUpdateSubmitRequested = false;
      draft.ticketDetailUpdateSubmitSucceeded = false;
      draft.ticketDetailUpdateSubmitFailed = false;
      break;

    case TICKET_DETAIL_UPDATE_SUBMIT_REQUESTED:
      draft.ticketDetailUpdateSubmitRequested = true;
      break;

    case TICKET_DETAIL_UPDATE_SUBMIT_SUCCEEDED:
      draft.ticketDetailUpdateSubmitRequested = false;
      draft.ticketDetailUpdateSubmitSucceeded = true;
      break;

    case TICKET_DETAIL_UPDATE_SUBMIT_FAILED:
      draft.ticketDetailUpdateSubmitRequested = false;
      draft.ticketDetailUpdateSubmitFailed = true;
      break;

    /*
     * TICKET_PAGINATED_LIST_FETCH
     */
    case TICKET_PAGINATED_LIST_FETCH:
      draft.ticketPaginatedList = {};
      draft.ticketPaginatedListFetchRequested = false;
      draft.ticketPaginatedListFetchSucceeded = false;
      draft.ticketPaginatedListFetchFailed = false;
      break;

    case TICKET_PAGINATED_LIST_FETCH_REQUESTED:
      draft.ticketPaginatedListFetchRequested = true;
      break;

    case TICKET_PAGINATED_LIST_FETCH_SUCCEEDED:
      draft.ticketPaginatedList = action.paginatedList;
      draft.ticketPaginatedListFetchRequested = false;
      draft.ticketPaginatedListFetchSucceeded = true;
      break;

    case TICKET_PAGINATED_LIST_FETCH_FAILED:
      draft.ticketPaginatedList = {};
      draft.ticketPaginatedListFetchRequested = false;
      draft.ticketPaginatedListFetchFailed = true;
      break;

    /*
     * TICKET_STATUS_LIST_FETCH
     */

    case TICKET_STATUS_LIST_FETCH:
      draft.ticketStatusList = [];
      draft.ticketStatusListFetchRequested = false;
      draft.ticketStatusListFetchSucceeded = false;
      draft.ticketStatusListFetchFailed = false;
      draft.ticketStatusListFetchError = null;
      break;

    case TICKET_STATUS_LIST_FETCH_REQUESTED:
      draft.ticketStatusListFetchRequested = true;
      break;

    case TICKET_STATUS_LIST_FETCH_SUCCEEDED:
      draft.ticketStatusListFetchRequested = false;
      draft.ticketStatusListFetchSucceeded = true;
      draft.ticketStatusList = action.ticketStatusList;
      break;

    case TICKET_STATUS_LIST_FETCH_FAILED:
      draft.ticketStatusListFetchRequested = false;
      draft.ticketStatusListFetchFailed = true;
      draft.ticketStatusListFetchError = action.error;
      break;
    case USER_TICKETS_PAGINATED_LIST_FETCH:
      draft.userTicketsPaginatedList = [];
      draft.userTicketsPaginatedListFetchRequested = false;
      draft.userTicketsPaginatedListFetchSucceeded = false;
      draft.userTicketsPaginatedListFetchFailed = false;
      draft.userTicketsPaginatedListFetchError = null;
      break;

    case USER_TICKETS_PAGINATED_LIST_FETCH_REQUESTED:
      draft.userTicketsPaginatedListFetchRequested = true;
      break;

    case USER_TICKETS_PAGINATED_LIST_FETCH_SUCCEEDED:
      draft.userTicketsPaginatedListFetchRequested = false;
      draft.userTicketsPaginatedListFetchSucceeded = true;
      draft.userTicketsPaginatedList = action.data;
      break;

    case USER_TICKETS_PAGINATED_LIST_FETCH_FAILED:
      draft.userTicketsPaginatedListFetchRequested = false;
      draft.userTicketsPaginatedListFetchFailed = true;
      draft.userTicketsPaginatedListFetchError = action.error;
      break;

    case USER_TICKETS_SERVICE_LIST_FETCH:
      draft.userTicketsServiceList = [];
      draft.userTicketsServiceListFetchRequested = false;
      draft.userTicketsServiceListFetchSucceeded = false;
      draft.userTicketsServiceListFetchFailed = false;
      draft.userTicketsServiceListFetchError = null;
      break;

    case USER_TICKETS_SERVICE_LIST_FETCH_REQUESTED:
      draft.userTicketsServiceListFetchRequested = true;
      break;

    case USER_TICKETS_SERVICE_LIST_FETCH_SUCCEEDED:
      draft.userTicketsServiceListFetchRequested = false;
      draft.userTicketsServiceListFetchSucceeded = true;
      draft.userTicketsServiceList = action.data;
      break;

    case USER_TICKETS_SERVICE_LIST_FETCH_FAILED:
      draft.userTicketsServiceListFetchRequested = false;
      draft.userTicketsServiceListFetchFailed = true;
      draft.userTicketsServiceListFetchError = action.error;
      break;

    case TICKET_STATUS_DATA_FETCH:
      draft.ticketStatusData = [];
      draft.ticketStatusDataFetchRequested = false;
      draft.ticketStatusDataFetchSucceeded = false;
      draft.ticketStatusDataFetchFailed = false;
      draft.ticketStatusDataFetchErrorMessage = null;
      break;

    case TICKET_STATUS_DATA_FETCH_REQUESTED:
      draft.ticketStatusData = [];
      draft.ticketStatusDataFetchRequested = true;
      draft.ticketStatusDataFetchSucceeded = false;
      draft.ticketStatusDataFetchFailed = false;
      draft.ticketStatusDataFetchErrorMessage = null;
      break;

    case TICKET_STATUS_DATA_FETCH_SUCCEEDED:
      draft.ticketStatusData = action.data;
      draft.ticketStatusDataFetchRequested = false;
      draft.ticketStatusDataFetchSucceeded = true;
      draft.ticketStatusDataFetchFailed = false;
      draft.ticketStatusDataFetchErrorMessage = null;
      break;

    case TICKET_STATUS_DATA_FETCH_FAILED:
      draft.ticketStatusData = [];
      draft.ticketStatusDataFetchRequested = false;
      draft.ticketStatusDataFetchSucceeded = false;
      draft.ticketStatusDataFetchFailed = true;
      draft.ticketStatusDataFetchErrorMessage = action.error;
      break;

    case TICKET_DETAIL_DATA_FETCH:
      draft.ticketDetailData = [];
      draft.ticketDetailDataFetchRequested = false;
      draft.ticketDetailDataFetchSucceeded = false;
      draft.ticketDetailDataFetchFailed = false;
      draft.ticketDetailDataFetchErrorMessage = null;
      break;

    case TICKET_DETAIL_DATA_FETCH_REQUESTED:
      draft.ticketDetailData = [];
      draft.ticketDetailDataFetchRequested = true;
      draft.ticketDetailDataFetchSucceeded = false;
      draft.ticketDetailDataFetchFailed = false;
      draft.ticketDetailDataFetchErrorMessage = null;
      break;

    case TICKET_DETAIL_DATA_FETCH_SUCCEEDED:
      draft.ticketDetailData = action.data;
      draft.ticketDetailDataFetchRequested = false;
      draft.ticketDetailDataFetchSucceeded = true;
      draft.ticketDetailDataFetchFailed = false;
      draft.ticketDetailDataFetchErrorMessage = null;
      break;

    case TICKET_DETAIL_DATA_FETCH_FAILED:
      draft.ticketDetailData = [];
      draft.ticketDetailDataFetchRequested = false;
      draft.ticketDetailDataFetchSucceeded = false;
      draft.ticketDetailDataFetchFailed = true;
      draft.ticketDetailDataFetchErrorMessage = action.error;
      break;

    case TICKET_QUEUE_DETAIL_DATA_FETCH:
      draft.ticketQueueDetailData = [];
      draft.ticketQueueDetailDataFetchRequested = false;
      draft.ticketQueueDetailDataFetchSucceeded = false;
      draft.ticketQueueDetailDataFetchFailed = false;
      draft.ticketQueueDetailDataFetchErrorMessage = null;
      break;

    case TICKET_QUEUE_DETAIL_DATA_FETCH_REQUESTED:
      draft.ticketQueueDetailData = [];
      draft.ticketQueueDetailDataFetchRequested = true;
      draft.ticketQueueDetailDataFetchSucceeded = false;
      draft.ticketQueueDetailDataFetchFailed = false;
      draft.ticketQueueDetailDataFetchErrorMessage = null;
      break;

    case TICKET_QUEUE_DETAIL_DATA_FETCH_SUCCEEDED:
      console.log(action.data);
      draft.ticketQueueDetailData = action.data;
      draft.ticketQueueDetailDataFetchRequested = false;
      draft.ticketQueueDetailDataFetchSucceeded = true;
      draft.ticketQueueDetailDataFetchFailed = false;
      draft.ticketQueueDetailDataFetchErrorMessage = null;
      break;

    case TICKET_QUEUE_DETAIL_DATA_FETCH_FAILED:
      draft.ticketQueueDetailData = [];
      draft.ticketQueueDetailDataFetchRequested = false;
      draft.ticketQueueDetailDataFetchSucceeded = false;
      draft.ticketQueueDetailDataFetchFailed = true;
      draft.ticketQueueDetailDataFetchErrorMessage = action.error;
      break;

    case TICKET_SERVICE_LIST_FETCH:
      draft.ticketServiceList = [];
      draft.ticketServiceListFetchRequested = false;
      draft.ticketServiceListFetchSucceeded = false;
      draft.ticketServiceListFetchFailed = false;
      draft.ticketServiceListFetchErrorMessage = null;
      break;

    case TICKET_SERVICE_LIST_FETCH_REQUESTED:
      draft.ticketServiceListFetchRequested = true;
      break;

    case TICKET_SERVICE_LIST_FETCH_SUCCEEDED:
      draft.ticketServiceList = action.data;
      draft.ticketServiceListFetchRequested = false;
      draft.ticketServiceListFetchSucceeded = true;
      break;

    case TICKET_SERVICE_LIST_FETCH_FAILED:
      draft.ticketServiceList = [];
      draft.ticketServiceListFetchRequested = false;
      draft.ticketServiceListFetchFailed = true;
      draft.ticketServiceListFetchErrorMessage = action.error;
      break;

    case LOCATION_CHANGE:
      // ticketPaginatedList
      draft.ticketPaginatedList = {};
      draft.ticketPaginatedListFetchRequested = false;
      draft.ticketPaginatedListFetchSucceeded = false;
      draft.ticketPaginatedListFetchFailed = false;

      // ticketServiceList
      draft.ticketServiceList = [];
      draft.ticketServiceListFetchRequested = false;
      draft.ticketServiceListFetchSucceeded = false;
      draft.ticketServiceListFetchFailed = false;
      draft.ticketServiceListFetchErrorMessage = null;

      draft.ticketAddSubmitRequested = false;
      draft.ticketAddSubmitSucceeded = false;
      draft.ticketAddSubmitSucceededTicketNumber = null;
      draft.ticketAddSubmitRequested = false;
      draft.ticketDetailUpdateSubmitRequested = false;
      draft.ticketDetailUpdateSubmitSucceeded = false;
      draft.ticketDetailUpdateSubmitRequested = false;
      draft.userTicketsPaginatedList = [];
      draft.userTicketsPaginatedListFetchRequested = false;
      draft.userTicketsPaginatedListFetchSucceeded = false;
      draft.userTicketsPaginatedListFetchFailed = false;
      draft.userTicketsPaginatedListFetchError = false;
      draft.userTicketsServiceList = [];
      draft.userTicketsServiceListFetchRequested = false;
      draft.userTicketsServiceListFetchSucceeded = false;
      draft.userTicketsServiceListFetchFailed = false;
      draft.userTicketsServiceListFetchError = false;
      draft.ticketStatusList = [];
      draft.ticketStatusListFetchRequested = false;
      draft.ticketStatusListFetchSucceeded = false;
      draft.ticketStatusListFetchFailed = false;
      draft.ticketStatusListFetchError = null;
      draft.ticketStatusData = [];
      draft.ticketStatusDataFetchRequested = false;
      draft.ticketStatusDataFetchSucceeded = false;
      draft.ticketStatusDataFetchFailed = false;
      draft.ticketStatusDataFetchErrorMessage = null;
      draft.ticketDetailData = [];
      draft.ticketDetailDataFetchRequested = false;
      draft.ticketDetailDataFetchSucceeded = false;
      draft.ticketDetailDataFetchFailed = false;
      draft.ticketDetailDataFetchErrorMessage = null;
      break;
  }
}, initialState);

export { initialState };
export default persistReducer(persistConfig, reducer);
