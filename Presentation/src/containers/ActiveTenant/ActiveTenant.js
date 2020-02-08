import React, { Component } from "react";
import Navbar from "../../components/Navbar/TenantNavbar";

class ActiveTenant extends Component {
  render() {
    return (
      <div>
        <Navbar />
        <h3>hello world from ActiveTenant</h3>
      </div>
    );
  }
}

export default ActiveTenant;
