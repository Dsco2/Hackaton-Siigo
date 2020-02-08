import * as actions from "../actionTypes";

const initialState = {
  customersList: [],
  activeCustomer: {}
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
  return {
    ...state,
    customersList: action.customersList
  };
};

export default reducer;
