import moment from 'moment';
import PropTypes from 'prop-types';
import React from 'react';

import { css } from '@emotion/core';
import { Button, Card, Divider, Timeline, Upload } from '@valtx-mi2/ui';

const timelineStyle = css({
  '.ant-timeline-item-content': {
    width: '100%',
    display: 'flex',
  },
});

const cardStyle = css({
  marginTop: '-5px',
});

const bodyStyle = css({
  padding: '20px',
});

function TicketQueueTimeline({ queue, dataSource }) {
  return (
    <div>
      <Divider css={{ marginBottom: '40px' }}>{queue}</Divider>

      <Timeline css={timelineStyle}>
        {dataSource.map((item, index) => {
          let regEx;
          let name = item.especialist;
          regEx = /"/;
          name = name.replace(regEx, '');
          regEx = /^([\w\s]*)/;
          const match = name.match(regEx);
          name = match && match.length > 0 ? match[0] : '';

          return (
            <Timeline.Item
              css={{ display: 'flex', width: '100%' }}
              // eslint-disable-next-line react/no-array-index-key
              key={`TimeLineItem ${index}`}
            >
              <div css={{ marginRight: '10px', minWidth: '80px' }}>
                {' '}
                <span css={{ fontWeight: 500 }}>
                  {moment(item.createdTime).format('hh:mm a')}
                </span>
              </div>

              <Card cardStyle={cardStyle} bodyStyle={bodyStyle}>
                <div css={{ marginBottom: '10px' }}>
                  <div css={{ fontWeight: '600' }}>Colaborador</div>
                  <div>{name}</div>
                </div>
                <div>
                  <div css={{ fontWeight: '600' }}>Detalle</div>
                  <div>{item.aBody}</div>
                </div>
                <Divider />
                <Upload
                  fileList={item.queueDetailAttachments}
                  showUploadList={{
                    showPreviewIcon: true,
                    showDownloadIcon: true,
                    showRemoveIcon: false,
                  }}
                />
              </Card>
            </Timeline.Item>
          );
        })}
      </Timeline>
    </div>
  );
}
/* <Timeline.Item>Create a services site 2015-09-01</Timeline.Item>
        <Timeline.Item>Solve initial network problems 2015-09-01</Timeline.Item>
        <Timeline.Item
          dot={<Icon type="clock-circle-o" style={{ fontSize: '16px' }} />}
          color="red"
        >
          Technical testing 2015-09-01
        </Timeline.Item>
        <Timeline.Item>Network problems being solved 2015-09-01</Timeline.Item> */

/* queueId: 59
articuleId: 475000
aBody: "jhf kflksdjflkjsdlkfj  dfkdfj dslkjflksdf"
createdTime: "2020-03-02T09:44:06"
createdBy: "MARIO VALENTIN ESCUDERO GUARDERAS"
especialist: ""CLAUDIA ELENA CISNEROS CONTRERAS" <swfiequipodes4@valtx.pe>"
historyType: 1
queueDetailAttachments: Array(2)
0: {articuleId: 475000, contentType: "image/png", fileName: "acceso denegado al documento.png; name=acceso denegado al documento.png", content: "iVBORw0KGgoAAAANSUhEUgAABTIAAAKGCAYAAAB5rGS5AAAAAX…AAMUTMgEAAACAwr2b/j+xG4o7tB/K9gAAAABJRU5ErkJggg=="}
1: {articuleId: 475000, contentType: "image/jpeg", fileName: "documento no acceso jpg.jpg; name=documento no acceso jpg.jpg", content: "/9j/4AAQSkZJRgABAQEAYABgAAD/4QCsRXhpZgAATU0AKgAAAA…FFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAf/Z"}
length: 2
__proto__: Array(0)  */

TicketQueueTimeline.propTypes = {
  queue: PropTypes.string.isRequired,
  // eslint-disable-next-line react/forbid-prop-types
  dataSource: PropTypes.array.isRequired,
};

export default TicketQueueTimeline;
