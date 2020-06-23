/* eslint-disable camelcase */

import Axios from 'axios';

const AssetsAPI = {
  async fetch(ownerId, identity) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/asset`,
      params: { ownerId },
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketServiceListFetch(identity) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/service`,
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketDetailUpdateSubmit(params, identity) {
    const { access_token } = identity.token;
    const { ticketId, description, attachments } = params;

    const form = new FormData();
    form.append('nroTicket', ticketId);
    form.append('description', description);
    attachments.forEach((file) => {
      form.append('attachments', file);
    });

    return Axios({
      method: 'put',
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: '/api/v1/ticket/incidence',
      data: form,
      headers: {
        'Content-Type': 'multipart/form-data',
        'content-Type': 'multipart/form-data',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async fetchOtrsServices(serviceId, identity) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/service/servicetwo/${!serviceId ? '' : serviceId}`,
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketPaginatedListFetch(params, currentPage, pageSize, identity) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/tracking/tickets-list-employee`,
      params: {
        ...params,
        pageIndex: currentPage - 1,
        pageSize,
      },
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketStatusListFetch(identity) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/tracking/ticket-states`,
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketStatusDataFetchRequestAsync(identity, ticketId) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/tracking/ticket-queue`,
      params: {
        nroTicket: ticketId,
      },
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketDetailDataFetchAsync(identity, ticketId) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/tracking/ticket-detail`,
      params: {
        nroTicket: ticketId,
      },
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketQueueDetailDataFetchAsync(identity, ticketId, queue) {
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/tracking/ticket-queue-detail`,
      params: {
        nroTicket: ticketId,
        nameQueue: queue,
      },
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async stolenAlertAddSubmit(params, identity) {
    const { ownerId, assetId, policeReportFile, affidavitFile } = params;
    const { access_token } = identity.token;
    const form = new FormData();
    form.append('UserDni', ownerId);
    form.append('AssetId', assetId);
    form.append('policeAlertFile', policeReportFile);
    form.append('affidavitFile', affidavitFile);
    return Axios({
      method: 'post',
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: '/api/v1/StolenAlert',
      data: form,
      headers: {
        'Content-Type': 'multipart/form-data',
        'content-Type': 'multipart/form-data',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async ticketAddSubmit(params, identity) {
    const { access_token } = identity.token;
    const { userDni, assetId, serviceId, description, attachments } = params;
    const form = new FormData();
    form.append('UserDni', userDni);
    form.append('AssetId', assetId);
    form.append('OtrsServiceId', serviceId);
    form.append('Description', description);
    attachments.forEach((file) => {
      form.append('attachments', file);
    });
    return Axios({
      method: 'post',
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: '/api/v1/ticket/incidence',
      data: form,
      headers: {
        'Content-Type': 'multipart/form-data',
        'content-Type': 'multipart/form-data',
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async assetReturnInfoPaginatedListFetch(params, pageIndex, pageSize, identity) {
    const { username } = identity.user;
    // eslint-disable-next-line camelcase
    const { access_token } = identity.token;
    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      url: `api/v1/customeruser/termination`,
      params: {
        nroDni: username,
        ...params,
        pageSize,
        pageIndex: pageIndex - 1,
      },
      timeout: 30000,
      headers: {
        'Content-Type': 'application/json',
        // eslint-disable-next-line camelcase
        Authorization: `Bearer ${access_token}`,
      },
    });
  },

  async assetReturnInfoUpdateSubmit(transactionData, identity) {
    // eslint-disable-next-line camelcase
    const { access_token } = identity.token;

    const dto = transactionData.map((item) => {
      return {
        idUser: item.id,
        dateEndcontrat: item.renewalDate !== null ? item.renewalDate : null,
      };
    });

    return Axios({
      baseURL: process.env.REACT_APP_API_ASSETS_IT_URL,
      method: 'post',
      url: 'api/v1/customeruser/termination',
      data: dto,
      timeout: 3000,
      headers: {
        'content-type': 'application/json',
        // eslint-disable-next-line camelcase
        Authorization: `Bearer ${access_token}`,
      },
    });
  },
};

export default AssetsAPI;
