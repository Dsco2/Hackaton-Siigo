import axios from "axios";
import * as actions from "../actionTypes";

export const fetchProducts = idTenant => {
  return dispatch => {
    return axios
      .get(`/Products/getProductsByTenant/${idTenant}`)
      .then(response => dispatch(updateProducts(response.data)))
      .catch(error => console.log(error.response));
  };
};

export const selectProduct = idProduct => {
  return dispatch => {
    return axios
      .get(`/Products/getProductsById/${idProduct}`)
      .then(response => dispatch(updateActiveProduct(response.data)))
      .catch(error => console.log(error.response));
  };
};

export const updateSuccessMessage = message => {
  return {
    type: actions.UPDATE_SUCCESS_MESSAGE,
    success: message
  };
};



export const updateProducts = productsList => {
  return {
    type: actions.UPDATE_PRODUCTS,
    productsList: productsList
  };
};

const updateActiveProduct = product => {
  return {
    type: actions.UPDATE_ACTIVE_PRODUCT,
    product: product
  };
};
