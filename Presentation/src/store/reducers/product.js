import * as actions from "../actionTypes";

const initialState = {
  productsToSearch: [],
  searchHistory: [],
  activeProduct: {}
};

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actions.UPDATE_PRODUCTS:
      return updateProducts(state, action);
      case actions.UPDATE_ACTIVE_PRODUCT:
        return updateActiveProduct(state, action);
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

export default reducer;
