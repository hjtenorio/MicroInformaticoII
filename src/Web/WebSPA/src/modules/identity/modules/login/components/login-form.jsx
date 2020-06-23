/* eslint-disable react/prop-types */

import { Button, Form, Input } from 'antd';
import React from 'react';

const FormItem = Form.Item;

const LoginForm = (props) => {
  const { form, submit, forgotPassword } = props;
  const { getFieldDecorator } = form;

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
    <Form onSubmit={handleSubmit} className="gx-signin-form gx-form-row0">
      <FormItem>
        {getFieldDecorator('username', {
          initialValue: '',
          rules: [
            {
              required: true,
              message: 'Debe ingresar un usuario',
            },
          ],
        })(<Input placeholder="Usuario" />)}
      </FormItem>
      <FormItem>
        {getFieldDecorator('password', {
          initialValue: '',
          rules: [
            {
              required: true,
              message: 'Debe ingresar una contraseña',
            },
          ],
        })(<Input type="password" placeholder="Contraseña" />)}
      </FormItem>

      <FormItem>
        <Button type="primary" className="gx-mb-0" htmlType="submit">
          Iniciar Sesión
        </Button>
      </FormItem>

      <div className="gx-flex-row gx-justify-content-between">
        <Button type="link" onClick={forgotPassword} css={{ padding: '0px' }}>
          ¿Olvido su contraseña?
        </Button>
      </div>
    </Form>
  );
};

const WrappedLoginForm = Form.create({ name: 'loginForm' })(LoginForm);

export default WrappedLoginForm;
