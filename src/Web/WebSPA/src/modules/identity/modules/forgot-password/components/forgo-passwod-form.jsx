/* eslint-disable react/prop-types */
import React from 'react';
import { Form, Icon, Button, Input, ValtxLogo } from '@valtx-mi2/ui';

import styled from '@emotion/styled';
import { useHistory } from 'react-router-dom';

const FormItem = Form.Item;

const ValtxLogoContainer = styled.div`
  padding-top: 40px;
`;

const ForgotPasswodForm = (props) => {
  const { form, submit } = props;
  const { getFieldDecorator } = form;
  const history = useHistory();

  const handleCancel = (e) => {
    e.preventDefault();
    form.resetFields();
    history.push('/');
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    form.validateFields((err, values) => {
      if (!err) {
        submit(values);
        form.resetFields();
      }
    });
  };

  return (
    <div className="gx-login-container">
      <div className="gx-login-content">
        <div className="gx-login-header">
          <ValtxLogoContainer>
            <ValtxLogo />
          </ValtxLogoContainer>
        </div>

        <div className="gx-mb-4">
          <h2>¿Olvidaste tu Contraseña?</h2>
          {/* <p>Recuperar tu contraseña es facil, solo </p> */}
        </div>

        <Form
          layout="vertical"
          onSubmit={handleSubmit}
          className="gx-login-form gx-form-row0"
        >
          <FormItem>
            {getFieldDecorator('dni', {
              rules: [
                {
                  required: true,
                  message: '¡Debe ingresar su numero de DNI!',
                },
              ],
            })(<Input type="text" placeholder="DNI" />)}
          </FormItem>

          <FormItem>
            <Button type="primary" htmlType="submit" block>
              Reestablecer Contraseña
            </Button>
            <Button
              css={{ marginBottom: '0px' }}
              type="link"
              onClick={handleCancel}
              block
            >
              Cancelar
            </Button>
          </FormItem>
        </Form>
      </div>
    </div>
  );
};

const WrappedForgotPasswordForm = Form.create({ name: 'forgotPasswordForm' })(
  ForgotPasswodForm
);

export default WrappedForgotPasswordForm;
