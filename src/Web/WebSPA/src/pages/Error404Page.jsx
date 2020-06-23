/* eslint-disable react/button-has-type */
import React from 'react';
import { Link } from 'react-router-dom';

const Error404 = () => (
  <div className="gx-page-error-container">
    <div className="gx-page-error-content">
      <div className="gx-error-code gx-mb-4">404</div>
      <h2 className="gx-text-center">Not Found</h2>
      <form className="gx-mb-4" role="search">
        <div className="gx-search-bar">
          <div className="gx-form-group">
            <input
              type="search"
              className="ant-input ant-input-lg"
              placeholder="Search..."
            />
            <button className="gx-search-icon">
              <i className="icon icon-search" />
            </button>
          </div>
        </div>
      </form>
      <p className="gx-text-center">
        <Link className="gx-btn gx-btn-primary" to="/">
          Ir a regresar
        </Link>
      </p>
    </div>
  </div>
);

export default Error404;
