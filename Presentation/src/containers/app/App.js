import React from "react";
import { Route, Switch, BrowserRouter } from "react-router-dom";
import "./App.css";
import Tenant from "../Tenants/Tenant";
import ActiveTenant from "../ActiveTenant/ActiveTenant";
import Customers from "../Customers/Customers";
import Products from "../Products/Products";

function App() {
  return (
    <BrowserRouter>
      <Switch>
        <Route exact path="/" component={Tenant} />
        <Route exact path="/customers" component={Customers} />
        <Route exact path="/products" component={Products} />
        <Route exact path="/active-tenant" component={ActiveTenant} />
      </Switch>
    </BrowserRouter>
  );
}

export default App;
