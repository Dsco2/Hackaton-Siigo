import axios from "axios";
import * as actions from "../actionTypes";

export const fetchTenants = () => {
  return dispatch => {
    axios
      .get("/tenant/getTenants")
      .then(response => dispatch(updateTenants(response.data)))
      .catch(error => console.log(error.response));
  };
};

export const createTenant = (name, theme) => {
  return dispatch => {
    const data = {
      name: name,
      theme: theme
    };

    axios
      .post("/tenant/createTenant", data)
      .then(response => dispatch(addTenant(response.data)))
      .catch(error => console.log(error.response));
  };
};

export const setActiveTenant = tenant => {
  return {
    type: actions.SET_ACTIVE_TENANT,
    activeTenant: tenant
  };
};

export const logout = () => {
  return {
    type: actions.SET_ACTIVE_TENANT,
    activeTenant: {}
  };
};

const addTenant = newTenant => {
  return {
    type: actions.ADD_TENANT,
    newTenant: newTenant
  };
};

const updateTenants = tenantsList => {
  return {
    type: actions.UPDATE_TENANTS,
    tenantsList: tenantsList
  };
};
