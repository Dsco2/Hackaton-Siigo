import * as actions from "../actionTypes";

const initialState = {
  tenantsList: [],
  activeTenant: {}
};

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actions.UPDATE_TENANTS:
      return updateTenants(state, action);
    default:
      return state;
  }
};

const updateTenants = (state, action) => {
  return {
    ...state,
    tenantsList: action.tenantsList
  };
};

export default reducer;
