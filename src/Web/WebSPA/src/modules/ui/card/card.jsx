import React from 'react';
import PropTypes from 'prop-types';

const Card = ({
  heading,
  children,
  styleName,
  childrenStyle,
  cardStyle,
  bodyStyle,
}) => {
  return (
    <div className="gx-card" css={cardStyle}>
      {heading && (
        <div className="gx-card-head">
          <h3 className="gx-card-title">{heading}</h3>
        </div>
      )}
      <div className="gx-card-body" css={bodyStyle}>
        {' '}
        {children}
      </div>
    </div>
  );
};

export default Card;
