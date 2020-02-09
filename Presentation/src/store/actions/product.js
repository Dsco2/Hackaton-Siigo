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

export const updateProducts = productsList => {
  return {
    type: actions.UPDATE_PRODUCTS,
    productsList: productsList
  };
};
