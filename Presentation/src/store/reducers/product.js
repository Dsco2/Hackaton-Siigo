import * as actions from "../actionTypes";

const initialState = {
  productsToSearch: []
};

const reducer = (state = initialState, action) => {
  switch (action.type) {
    case actions.UPDATE_PRODUCTS:
      return updateProducts(state, action);
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

export default reducer;
