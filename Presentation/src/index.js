import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./containers/app/App";
import { Provider } from "react-redux";
import { createStore, combineReducers, applyMiddleware } from "redux";
import thunk from "redux-thunk";
import tenant from "./store/reducers/tenant";
import customer from "./store/reducers/customer";
import axios from "axios";

console.log("current environment: " + process.env.NODE_ENV);
const apiUrl =
  process.env.NODE_ENV === "production"
    ? process.env.REACT_APP_PROD_API_URL
    : process.env.REACT_APP_DEV_API_URL;
axios.defaults.baseURL = apiUrl;
console.log("current api url: " + apiUrl);

const reducer = combineReducers({
  tenant,
  customer
});

const store = createStore(reducer, applyMiddleware(thunk));

ReactDOM.render(
  <Provider store={store}>
    <App />
  </Provider>,
  document.getElementById("root")
);
