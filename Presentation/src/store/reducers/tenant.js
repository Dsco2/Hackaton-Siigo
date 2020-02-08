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
    case actions.SET_ACTIVE_TENANT:
      return setActiveTenant(state, action);
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

const addTenant = (state, action) => {
  const updatedTenantsList = [...state.tenantsList, action.newTenant];
  return {
    ...state,
    tenantsList: updatedTenantsList
  };
};

const setActiveTenant = (state, action) => {
  return {
    ...state,
    activeTenant: action.activeTenant
  };
};

export default reducer;
