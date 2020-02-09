import React, { Component } from "react";
import Navbar from "../../components/Navbar/TenantNavbar";
import { Link } from "react-router-dom";
import { connect } from "react-redux";

class ActiveTenant extends Component {
  render() {
    return (
      <div>
        <Navbar />
        <div className="container">
          <div className="jumbotron mt-4">
            <h1 className="display-4">Hola, {this.props.activeTenantName}!</h1>
            <p className="lead">Bienvenido a este sistema</p>
            <hr className="my-4" />
            <p>
              Puede navegar por medio de estos botones o por el menú superior
            </p>
            <div className="row">
              <div className="col-6 col-md-3">
                <Link
                  className={`btn btn-outline-${this.props.theme} btn-lg`}
                  to="/products"
                >
                  Productos
                </Link>
              </div>
              <div className="col-6 col-md-3">
                <Link
                  className={`btn btn-outline-${this.props.theme} btn-lg`}
                  to="/customers"
                >
                  Clientes
                </Link>
              </div>
            </div>
          </div>
        </div>
      </div>
    );
  }
}

const mapStateToProps = state => {
  return {
    activeTenantName: state.tenant.activeTenant.name,
    theme: state.tenant.activeTenant.theme
  };
};

export default connect(mapStateToProps)(ActiveTenant);
