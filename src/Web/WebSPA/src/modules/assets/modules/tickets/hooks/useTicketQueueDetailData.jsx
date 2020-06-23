/* eslint-disable no-use-before-define */
import React, { useState, useEffect } from 'react';
import { createStructuredSelector } from 'reselect';
import { useSelector, useDispatch } from 'react-redux';
import nanoid from 'nanoid';
import { useIdentity } from '@valtx-mi2/identity';
import {
  makeTicketQueueDetailDataSelector,
  makeTicketQueueDetailDataFetchRequestedSelector,
  makeTicketQueueDetailDataFetchSucceededSelector,
  makeTicketQueueDetailDataFetchFailedSelector,
  makeTicketQueueDetailDataFetchErrorMessageSelector,
} from '../store/selectors';

import { ticketQueueDetailDataFetchAction } from '../store/actions';

const selector = createStructuredSelector({
  ticketQueueDetailData: makeTicketQueueDetailDataSelector(),
  ticketQueueDetailDataFetchRequested: makeTicketQueueDetailDataFetchRequestedSelector(),
  ticketQueueDetailDataFetchSucceeded: makeTicketQueueDetailDataFetchSucceededSelector(),
  ticketQueueDetailDataFetchFailed: makeTicketQueueDetailDataFetchFailedSelector(),
  ticketQueueDetailDataFetchErrorMessage: makeTicketQueueDetailDataFetchErrorMessageSelector(),
});

function useTicketQueueDetailData() {
  const dispatch = useDispatch();
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  const identity = useIdentity();

  const {
    ticketQueueDetailData,
    ticketQueueDetailDataFetchRequested,
    ticketQueueDetailDataFetchSucceeded,
    ticketQueueDetailDataFetchFailed,
    ticketQueueDetailDataFetchErrorMessage,
  } = useSelector(selector);

  useEffect(() => {
    if (ticketQueueDetailDataFetchRequested) {
      onTicketQueueDetailDataFetchRequested();
    }

    if (ticketQueueDetailDataFetchSucceeded) {
      onTicketQueueDetailDataFetchSucceeded();
    }

    if (ticketQueueDetailDataFetchFailed) {
      onTicketQueueDetailDataFetchFailed();
    }
  }, [
    ticketQueueDetailDataFetchRequested,
    ticketQueueDetailDataFetchSucceeded,
    ticketQueueDetailDataFetchFailed,
  ]);

  function onTicketQueueDetailDataFetchRequested() {
    setData([]);
    setIsLoading(true);
  }

  function onTicketQueueDetailDataFetchSucceeded() {
    const ticketQueueDetailDataWithFiles = ticketQueueDetailData
      ? ticketQueueDetailData.map((queueItem) => {
          const queueDetailAttachementsWithFiles = queueItem.queueDetailAttachments.map(
            (attachment) => {
              const byteCharacters = attachment.content;
              const byteNumbers = new Array(byteCharacters.length);
              for (let i = 0; i < byteCharacters.length; i++) {
                byteNumbers[i] = byteCharacters.charCodeAt(i);
              }
              const byteArray = new Uint8Array(byteNumbers);
              const file = new File([byteArray], attachment.fileName, {
                type: attachment.contentType,
              });
              file.uid = `rc-upload-1583362059968-2${nanoid()}`;

              return file;
            }
          );

          return {
            ...queueItem,
            queueDetailAttachments: queueDetailAttachementsWithFiles,
          };
        })
      : [];
    setData(ticketQueueDetailDataWithFiles);
    console.log(ticketQueueDetailDataWithFiles);
    setIsLoading(false);
  }

  function onTicketQueueDetailDataFetchFailed() {
    console.log(ticketQueueDetailDataFetchErrorMessage);
    setIsLoading(false);
  }

  const fetch = (ticketNumber, queue) => {
    dispatch(ticketQueueDetailDataFetchAction(identity, ticketNumber, queue));
  };

  return [data, fetch, isLoading];
}

export default useTicketQueueDetailData;
