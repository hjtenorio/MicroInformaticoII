/* eslint-disable react/prop-types */

import React from 'react';

import styled from '@emotion/styled';
import { Step, Steps } from '@valtx-mi2/ui';

const CustomSteps = styled(Steps)`
  padding-top: 10px;
  margin-bottom: 20px;
`;

const CustomStep = styled(Step)`
  & .ant-steps-item-description {
    font-size: 0.8rem;
  }
`;

const StepsProcess = ({ current, steps }) => {
  return (
    <CustomSteps current={current} progressDot>
      {steps.map((item) => (
        <CustomStep
          key={item.title}
          title={item.title}
          description={item.description}
        />
      ))}
    </CustomSteps>
  );
};

export default StepsProcess;
