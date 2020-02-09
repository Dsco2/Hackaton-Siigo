import * as actions from "../actionTypes";
import { bindActionCreators } from "redux";

const initialState = {
  productsToSearch: [],
  searchHistory: [],
  activeProduct: {},
  successMessage: "",
  errorMessage : ""
};

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actions.UPDATE_PRODUCTS:
      return updateProducts(state, action);
      case actions.UPDATE_ACTIVE_PRODUCT:
        return updateActiveProduct(state, action);
        case actions.UPDATE_SUCCESS_MESSAGE:
          return updateSuccessMessage(state, action)
    default:
      return state;
  }
};

const updateProducts = (state, action) => {
  return {
    ...state,
    productsToSearch: action.productsList
  };
};

const updateActiveProduct = (state, action) => {
  debugger;
  return {
    ...state,
    activeProduct: action.product
  }
}

const updateSuccessMessage = (state, action) => {
  debugger;
  return {
    ...state,
    successMessage: action.success 
  }
}

export default reducer;
