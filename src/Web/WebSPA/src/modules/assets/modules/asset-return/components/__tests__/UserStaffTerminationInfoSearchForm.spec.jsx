import React from 'react';
import ReactDOM from 'react-dom';

import Enzyme, { shallow, render, mount } from 'enzyme';
import toJson from 'enzyme-to-json';
import Adapter from 'enzyme-adapter-react-16';
import UserStaffTerminationInfoSearchFormBase from '../UserStaffTerminationInfoSearchFormBase';

Enzyme.configure({ adapter: new Adapter() });
// Basic Test with Enzyme
it('renders correctly enzyme', () => {
  const wrapper = shallow(<UserStaffTerminationInfoSearchFormBase />);

  expect(toJson(wrapper)).toMatchSnapshot();
});

it('renders correctly enzyme', () => {
  const wrapper = mount(<M2 />);

  expect(toJson(wrapper)).toMatchSnapshot();
});
