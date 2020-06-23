import { useDispatch, useSelector } from 'react-redux';
import { useIdentity } from '@valtx-mi2/identity';
import { createStructuredSelector } from 'reselect';
import {
  makeTicketStatusListSelector,
  makeTicketStatusListFetchRequestedSelector,
} from '../store/selectors';
import { ticketStatusListFetchAction } from '../store/actions';

function useTicketStatusList() {
  const dispatch = useDispatch();
  const identity = useIdentity();

  const { ticketStatusList, ticketStatusListFetchRequested } = useSelector(
    createStructuredSelector({
      ticketStatusList: makeTicketStatusListSelector(),
      ticketStatusListFetchRequested: makeTicketStatusListFetchRequestedSelector(),
    })
  );

  function ticketStatusListFetch() {
    dispatch(ticketStatusListFetchAction(identity));
  }
  

  return {
    ticketStatusList,
    ticketStatusListFetch,
    ticketStatusListFetchRequested,
  };
}

export default useTicketStatusList;
