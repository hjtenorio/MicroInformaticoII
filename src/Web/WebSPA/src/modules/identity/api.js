/*
 * @Author: mikey.zhaopeng
 * @Date: 2020-03-18 00:49:09
 * @Last Modified by: mikey.zhaopeng
 * @Last Modified time: 2020-03-18 00:51:15
 */

import Axios from 'axios';
import FormData from 'form-data';
import moment from 'moment';

const IdentityAPI = {
  /**
   * authenticate
   *
   * @param {*} username
   * @param {*} password
   * @returns
   */
  async authenticate(username, password) {
    const form = new FormData();
    form.set('username', username);
    form.set('password', password);
    form.set('grant_type', 'client_credentials');
    form.set('scope', 'AssetsITClient');
    form.set('client_id', 'client_api_flow');
    form.set('client_secret', '012536EF-FRT0-4Y09-8PCA-XCTHBC2F12W');
    return Axios({
      method: 'post',
      baseURL: process.env.REACT_APP_API_IDENTITY_URL,
      url: '/api/v1/Identity/Authenticate',
      data: form,
      headers: {
        'Content-Type': 'multipart/form-data',
      },
    });
  },

  async forgotPassword(dni) {
    return Axios({
      method: 'post',
      baseURL: process.env.REACT_APP_API_IDENTITY_URL,
      url: '/api/v1/Identity/ForgotPassword',
      params: {
        nroDni: dni,
      },
      headers: { 'Content-Type': 'application/json' },
    });
  },

  async resetPassword(token, password) {
    return Axios({
      method: 'post',
      baseURL: process.env.REACT_APP_API_IDENTITY_URL,
      url: '/api/v1/Identity/ResetPassword',
      params: {
        token,
        newPassword: password,
      },
      headers: { 'Content-Type': 'application/json' },
    });
  },
};

export default IdentityAPI;
