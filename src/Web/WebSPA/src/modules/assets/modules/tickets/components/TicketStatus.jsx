/* eslint-disable react/prop-types */
/*
 * @Author: gvillena
 * @Date: 2020-03-02 11:35:03
 * @Last Modified by: gvillena
 * @Last Modified time: 2020-03-02 18:40:03
 */

import moment from 'moment';
import PropTypes from 'prop-types';
import React from 'react';

import { Button, Carousel, Icon, Steps } from '@valtx-mi2/ui';

const { Step } = Steps;

const style = {
  '.BrainhubCarousel__arrows': {
    backgroundColor: '#1890ff',
    margin: '0px 10px',
  },

  '.BrainhubCarousel__arrows[disabled]': {
    backgroundColor: '#ccc',
    margin: '0px 10px',
  },
};

/**
 * TicketStatusProgress
 *
 * @export
 * @param {*} { dataSource }
 * @returns
 */
function TicketStatus({
  dataSource,
  onShowQueueTimeline,
  onHideQueueTimeline,
  isQueueTimelineVisible,
  activeQueue,
  ...rest
}) {
  //   ticketNumber: "080084362"
  // typeID: "2"
  // type: "Incidencia"
  // work: ""
  // queue: "OTRS"
  // processQueue: "OTRS"
  // startTime: "2020-03-02 09:44:06"
  // endTime: "2020-03-02 09:44:06"
  // diferenceTime: "00:00:00"
  // status: "Finalizado"

  const statusTextLowerCase = (statusText) =>
    statusText
      ? statusText
          .toLowerCase()
          .trimStart()
          .trimEnd()
      : '';

  function getQueueStatus(status) {
    // eslint-disable-next-line no-underscore-dangle
    let _status;
    switch (status) {
      case 'Nuevo':
        _status = 'wait';
        break;

      case 'Cerrado Satisfactoriamente':
        _status = 'finish';
        break;

      case 'Cerrado Insatisfactoriamente':
        _status = 'finish';
        break;

      case 'Abierto':
        _status = 'process';
        break;

      case 'Retirado':
        _status = 'process';
        break;

      case 'Recordatorio pendiente':
        _status = 'process';
        break;

      case 'Fusionado':
        _status = 'process';
        break;

      default:
        _status = '';
        break;
    }
    return _status;
  }

  // eslint-disable-next-line react/jsx-props-no-spreading
  return (
    <Carousel css={style} slidesPerPage={3} arrows>
      {dataSource.map((step, index) => (
        <Steps>
          {statusTextLowerCase(step.status) !== 'fin de atención' && (
            <Step
              // eslint-disable-next-line react/jsx-props-no-spreading
              {...rest}
              key={index}
              title={step.processQueue}
              status={getQueueStatus(step.status)}
              subTitle={
                <div
                  css={{
                    fontSize: '0.7rem',
                    lineHeight: '1.1rem',
                    marginBottom: '8px',
                  }}
                >
                  {(getQueueStatus(step.status) === 'process' ||
                    getQueueStatus(step.status) === 'finish') && (
                    <div>
                      Inicio de atención:{' '}
                      {moment(step.startTime).format('h:mm a')}
                    </div>
                  )}

                  {(getQueueStatus(step.status) === 'finish' ||
                    getQueueStatus(step.status) === 'error') && (
                    <div>
                      Fin de atención: {moment(step.endTime).format('h:mm a')}
                    </div>
                  )}
                  <div css={{ fontWeight: 500 }}>Estado: {step.status}</div>
                </div>
              }
              description={
                isQueueTimelineVisible && activeQueue === step.processQueue ? (
                  <Button
                    icon="eye"
                    type="primary"
                    size="small"
                    onClick={() => onHideQueueTimeline()}
                  >
                    Ocultar detalles{' '}
                  </Button>
                ) : (
                  <Button
                    icon="eye"
                    type="primary"
                    size="small"
                    onClick={() => onShowQueueTimeline(step.processQueue)}
                  >
                    Ver detalles{' '}
                  </Button>
                )
              }
            />
          )}
        </Steps>
      ))}
    </Carousel>
  );
}

TicketStatus.propTypes = {
  // eslint-disable-next-line react/forbid-prop-types
  dataSource: PropTypes.array.isRequired,
};

export default TicketStatus;

// /* <Carousel css={styles} {...props}> */
//   <div>
//     <h3>1</h3>
//   </div>
//   <div>
//     <h3>2</h3>
//   </div>
//   <div>
//     <h3>3</h3>
//   </div>
// </Carousel>;
