import * as actions from "../actionTypes";

const initialState = {
  tenantsList: [],
  activeTenant: {}
};

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actions.UPDATE_TENANTS:
      return updateTenants(state, action);
    case actions.ADD_TENANT:
      return addTenant(state, action);
    default:
      return state;
  }
};

const updateTenants = (state, action) => {
  debugger;
  return {
    ...state,
    tenantsList: action.tenantsList
  };
};

const addTenant = (state, action) => {
  const updatedTenantsList = [...state.tenantsList, action.newTenant];
  return {
    ...state,
    tenantsList: updatedTenantsList
  };
};

export default reducer;
