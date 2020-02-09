import * as actions from "../actionTypes";

const initialState = {
  customersToSearch: [],
  searchHistory: []
};

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actions.UPDATE_CUSTOMERS:
      return updateCustomers(state, action);
    default:
      return state;
  }
};

const updateCustomers = (state, action) => {
  const temp = {
    ...state,
    customersToSearch: action.customersList
  };
  return temp;
};

export default reducer;
