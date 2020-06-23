import React from 'react';
import Button from './button';
import Divider from '../divider';
import 'antd/dist/antd.css';

export default { title: 'Button' };

export const basic = () => {
  return (
    <div>
      <Button size="small">Small</Button>
      <Button>Default</Button>
      <Button size="large">Large</Button>
    </div>
  );
};

export const primary = () => {
  return (
    <div>
      <div>
        <Button type="primary" size="small">
          Small
        </Button>
      </div>
      <Divider />
      <div>
        <Button type="primary">Default</Button>
      </div>
      <Divider />
      <div>
        <Button type="primary" size="large">
          Large
        </Button>
      </div>
    </div>
  );
};

export const dashed = () => <Button type="dashed">Hola Mundo</Button>;

export const danger = () => <Button type="danger">Hola Mundo</Button>;

export const link = () => <Button type="link">Hola Mundo</Button>;

export const emoji = () => (
  <Button>
    <span role="img" aria-label="so cool">
      😀 😎 👍 💯
    </span>
  </Button>
);
