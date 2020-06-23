/*
 * @Author: gvillena
 * @Date: 2020-03-09 11:09:16
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-09 11:09:46
 */
import React from 'react';
import ReactDOM from 'react-dom';
import Micro2 from './micro2';
import Micro2Context from './context';
import * as serviceWorker from './serviceWorker';

ReactDOM.render(
  <Micro2Context>
    <Micro2 />
  </Micro2Context>,
  document.getElementById('root')
);
serviceWorker.unregister();
