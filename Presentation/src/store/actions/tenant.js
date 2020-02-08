import axios from "axios";
import * as actions from "../actionTypes";

export const fetchTenants = () => {
  return dispatch => {
    axios
      .get("/tenant/getTenants")
      .then(response => console.log(response))
      .catch(error => console.log(error.response));
  };
};
