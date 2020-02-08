import React from "react";
import { Route, Switch, BrowserRouter } from "react-router-dom";
import "./App.css";
import SearchCustomers from "../Search/SearchCustomers";
import SearchProducts from "../Search/SearchProducts";
import UplaodData from "../UploadData/UplaodData";
import Tenant from "../Tenants/Tenant";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route exact path="/" component={Tenant} />
        <Route exact path="/search-customers" component={SearchCustomers} />
        <Route exact path="/search-products" component={SearchProducts} />
        <Route exact path="/upload-data" component={UplaodData} />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
