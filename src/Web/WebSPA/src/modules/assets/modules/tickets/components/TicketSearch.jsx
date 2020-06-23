import PropTypes from 'prop-types';
import React, { useState } from 'react';

import { css } from '@emotion/core';
import styled from '@emotion/styled';
import {
  Button,
  Col,
  DatePicker,
  Form,
  Input,
  Row,
  Select,
} from '@valtx-mi2/ui';

const { Option } = Select;

// eslint-disable-next-line react/prop-types
function TicketsPageSearchFormBase({ form, onSearch, statusDataSource }) {
  // eslint-disable-next-line react/prop-types
  const { getFieldDecorator } = form;
  const [startDate, setStartDate] = useState(null);
  const [endDate, setEndDate] = useState(null);

  function onSubmit(e) {
    e.preventDefault();
    // eslint-disable-next-line react/prop-types
    form.validateFields((err, values) => {
      if (!err) {
        console.log(values);
        onSearch(values);
      }
    });
  }

  const formItem = css`
    width: 100%;
    .ant-col {
      width: 100%;
    }
  `;

  const col = css`
    padding: 0px;
  `;

  const row = css`
    padding: 0px;
  `;

  const formCss = css`
    padding: 0px -8px;
  `;

  return (
    <Form
      css={formCss}
      name="ticket-search"
      onSubmit={onSubmit}
      layout="inline"
    >
      <Row css={row}>
        <Col span={12} css={col}>
          <Form.Item name="nroTicketTitle" css={formItem}>
            {getFieldDecorator(
              'nroTicketTitle',
              {}
            )(
              <Input placeholder="Realice su busqueda con su nro. ticket o solicitud" />
            )}
          </Form.Item>
        </Col>

        <Col span={6} css={col}>
          <Form.Item name="startDate" css={formItem}>
            {getFieldDecorator('startDate', {
              initialValue: null,
            })(
              <DatePicker
                defaultPickerValue={null}
                placeholder="Desde"
                format="DD/MM/YYYY"
                disabledDate={(current) =>
                  current.isSameOrAfter(form.getFieldValue('endDate'))
                }
              />
            )}
          </Form.Item>
        </Col>

        <Col span={6} css={col}>
          <Form.Item name="endDate" css={formItem}>
            {getFieldDecorator('endDate', { initialValue: null })(
              <DatePicker
                defaultPickerValue={null}
                placeholder="Hasta"
                format="DD/MM/YYYY"
                disabledDate={(current) =>
                  current.isSameOrBefore(form.getFieldValue('startDate'))
                }
              />
            )}
          </Form.Item>
        </Col>
      </Row>

      <Row>
        <Col span={6} css={col}>
          <Form.Item name="serviceTypeId" css={formItem}>
            {getFieldDecorator('serviceTypeId', {
              initialValue: '2',
            })(
              <Select placeholder="Tipo de Solicitud" disabled>
                <Option key="2" value="2">
                  Incidencia
                </Option>
              </Select>
            )}
          </Form.Item>
        </Col>
        <Col span={6} css={col}>
          <Form.Item name="ticketStatusId" css={formItem}>
            {getFieldDecorator(
              'ticketStatusId',
              {}
            )(
              <Select placeholder="Estado" allowClear>
                {statusDataSource.map((item) => (
                  <Option key={item.id} value={item.id}>
                    {item.name}
                  </Option>
                ))}
              </Select>
            )}
          </Form.Item>
        </Col>

        <Col span={12} css={col}>
          <Form.Item css={formItem}>
            <Button type="primary" htmlType="submit" icon="search">
              Buscar
            </Button>
          </Form.Item>
        </Col>
      </Row>
    </Form>
  );
}

const TicketsPageSearchForm = Form.create({
  name: 'ticket-search-form',
})(TicketsPageSearchFormBase);

const H2 = styled.h3`
  margin-bottom: 15px;
`;

function TicketsPageSearch({ onSearch, statusDataSource }) {
  return (
    <div>
      <H2>Buscar Tickets</H2>
      <TicketsPageSearchForm
        onSearch={onSearch}
        statusDataSource={statusDataSource}
      />
    </div>
  );
}

TicketsPageSearch.propTypes = {
  onSearch: PropTypes.func.isRequired,
  // eslint-disable-next-line react/forbid-prop-types
  statusDataSource: PropTypes.array.isRequired,
};

export default TicketsPageSearch;
