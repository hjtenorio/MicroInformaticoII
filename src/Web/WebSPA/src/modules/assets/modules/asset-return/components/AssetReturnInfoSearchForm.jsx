/* eslint-disable react/prop-types */

import moment from 'moment';
import PropTypes from 'prop-types';
import React from 'react';

import { css } from '@emotion/core';
import { Button, Col, DatePicker, Form, Input, Row } from '@valtx-mi2/ui';

const formItemStyle = css`
  .ant-col.ant-form-item-control-wrapper {
    width: 100%;
  }
`;

/**
 * UserStaffTerminationInfoSearchFormBase
 *
 * @param {*} { form, onSearchSubmit }
 * @returns
 */
function AssetReturnInfoSearchFormBase({ form, onSearchSubmit }) {
  /**
   * onSubmit
   *
   * @param {*} e
   */
  function onSubmit(e) {
    e.preventDefault();

    form.validateFields((err, values) => {
      onSearchSubmit(values);
    });
  }

  const { getFieldDecorator } = form;

  const defaultStartDate = moment();
  const defaultEndDate = moment().add(1, 'months');

  return (
    <Form onSubmit={onSubmit} layout="inline">
      <Form.Item>
        {getFieldDecorator('fullName', {
          rules: [],
        })(
          <Input
            css={{ minWidth: '500px' }}
            placeholder="Realice su búsqueda por nombres y/o apellidos"
          />
        )}
      </Form.Item>

      <Form.Item wrapperCol={{ span: 0 }}>
        {getFieldDecorator('startDate', {
          rules: [],
          initialValue: defaultStartDate,
        })(
          <DatePicker
            css={{ display: 'none' }}
            format="DD/MM/YYYY"
            placeholder="Desde"
            disabled
          />
        )}
      </Form.Item>

      <Form.Item>
        {getFieldDecorator('endDate', {
          rules: [],
          initialValue: defaultStartDate,
        })(
          <DatePicker
            format="DD/MM/YYYY"
            placeholder="Hasta"
            disabledDate={(current) => {
              return (
                current.valueOf() < moment(defaultStartDate).valueOf() ||
                current.valueOf() > moment(defaultEndDate).valueOf()
              );
            }}
          />
        )}
      </Form.Item>
      <Form.Item>
        <Button type="primary" icon="search" htmlType="submit" block>
          Buscar
        </Button>
      </Form.Item>
    </Form>
  );
}

const AssetReturnInfoSearchForm = Form.create({
  name: 'AssetReturnInfoSearchForm',
})(AssetReturnInfoSearchFormBase);

export default AssetReturnInfoSearchForm;
