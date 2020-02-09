import axios from "axios";
import * as actions from "../actionTypes";

export const fetchCustomers = idTenant => {
  return dispatch => {
    return axios
      .get(`/Customers/getCustomerByTenant/${idTenant}`)
      .then(response => dispatch(updateCustomers(response.data)))
      .catch(error => console.log(error.response));
  };
};

export const selectCustomer = idCustomer => {
  return dispatch => {
    return axios
      .get(`/Customers/GetCustomerById/${idCustomer}`)
      .then(response => console.log(response))
      .catch(error => console.log(error.response));
  };
};

export const updateCustomers = customersList => {
  return {
    type: actions.UPDATE_CUSTOMERS,
    customersList: customersList
  };
};
