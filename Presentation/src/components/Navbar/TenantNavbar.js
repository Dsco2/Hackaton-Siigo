import React, { Component } from "react";
import { Link, Redirect } from "react-router-dom";
import { connect } from "react-redux";
import * as actions from "../../store/actionCreators";

class Navbar extends Component {
  render() {
    return (
      <nav
        className={`navbar navbar-expand-lg navbar-dark bg-${this.props.activeTenant.theme}`}
      >
        <Link className="navbar-brand" to="/active-tenant">
          {this.props.activeTenant.name}
        </Link>
        <button
          className="navbar-toggler"
          type="button"
          data-toggle="collapse"
          data-target="#navbarSupportedContent"
          aria-controls="navbarSupportedContent"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>

        <div className="collapse navbar-collapse" id="navbarSupportedContent">
          <ul className="navbar-nav mr-auto">
            <li className="nav-item active">
              <Link className="nav-link" to="/">
                Inicio
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/products">
                Productos
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/customers">
                Clientes
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" onClick={this.props.logout} to="/">
                Cerrar Sesión
              </Link>
              {!this.props.activeTenant.idTenant && <Redirect to="/" />}
            </li>
          </ul>
        </div>
      </nav>
    );
  }
}

const mapStateToProps = state => {
  return {
    activeTenant: state.tenant.activeTenant
  };
};

const mapDispatchToProps = dispatch => {
  return {
    logout: () => dispatch(actions.logout())
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Navbar);
