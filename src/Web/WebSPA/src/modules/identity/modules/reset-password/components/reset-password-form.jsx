/* eslint-disable no-console */
/* eslint-disable react/prop-types */
import React, { useState } from 'react';
import { ValtxLogo } from '@valtx-mi2/ui';
import { Form, Input, Button } from 'antd';
import { useDispatch } from 'react-redux';
import { push } from 'connected-react-router';

const FormItem = Form.Item;

function ResetPasswordForm({ form, submit }) {
  const dispatch = useDispatch();

  const [confirmDirty, setConfirmDirty] = useState(false);

  const handleSubmit = (e) => {
    e.preventDefault();
    form.validateFields((err, values) => {
      if (!err) {
        console.log('Received values of form: ', values);
        submit({ password: form.getFieldValue('password') });
      }
    });
  };

  const handleConfirmBlur = (e) => {
    const { value } = e.target;
    setConfirmDirty(confirmDirty || !!value);
  };

  const compareToFirstPassword = (rule, value, callback) => {
    if (value && value !== form.getFieldValue('password')) {
      callback('Two passwords that you enter is inconsistent!');
    } else {
      callback();
    }
  };

  const validateToNextPassword = (rule, value, callback) => {
    if (value && confirmDirty) {
      form.validateFields(['confirm'], { force: true });
    }
    callback();
  };

  const { getFieldDecorator } = form;
  return (
    <div className="gx-login-container">
      <div className="gx-login-content">
        <div className="gx-login-header">
          <ValtxLogo />
        </div>
        <div className="gx-mb-4">
          <h2>Reestablecer Contraseña</h2>
        </div>

        <Form onSubmit={handleSubmit} className="gx-login-form gx-form-row0">
          <FormItem>
            {getFieldDecorator('password', {
              rules: [
                {
                  required: true,
                  message: '¡Ingrese su contraseña!',
                },
                {
                  validator: validateToNextPassword,
                },
              ],
            })(
              <Input
                type="password"
                placeholder="Ingrese su nueva contraseña"
              />
            )}
          </FormItem>

          <FormItem>
            {getFieldDecorator('confirm', {
              rules: [
                {
                  required: true,
                  message: '¡Confirme su contraseña!',
                },
                {
                  validator: compareToFirstPassword,
                },
              ],
            })(
              <Input
                placeholder="Vuelva a ingresar su nueva contraseña"
                type="password"
                onBlur={handleConfirmBlur}
              />
            )}
          </FormItem>

          <FormItem>
            <Button type="primary" htmlType="submit" block>
              Reestablecer Contraseña
            </Button>
            <Button
              css={{ marginBottom: '0px' }}
              type="link"
              onClick={() => dispatch(push('/identity/login'))}
              block
            >
              Cancelar
            </Button>
          </FormItem>
        </Form>
      </div>
    </div>
  );
}

const WrappedResetPasswordForm = Form.create({ name: 'resetPasswordForm' })(
  ResetPasswordForm
);

export default WrappedResetPasswordForm;
