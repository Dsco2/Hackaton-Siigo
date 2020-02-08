import React, { Component } from "react";
import SiigoNavbar from "../../components/Navbar/SiigoNavbar";
import CreateTenantForm from "../../components/Tenants/CreateTenantForm";
import { connect } from "react-redux";
import * as actions from "../../store/actionCreators";
import * as classes from "./Tenant.module.css";
import { Redirect } from "react-router";

class Tenant extends Component {
  componentDidMount() {
    this.props.fetchTenants();
  }

  handleCreateTenant = (name, theme) => {
    this.props.createTenant(name, theme);
  };

  handleSelectTenant = tenant => {
    this.props.setActiveTenant(tenant);
  };

  render() {
    const tenantsJsx = this.props.tenants ? (
      this.props.tenants.map(tenant => {
        return (
          <div className="col-12 col-md-4" key={tenant.idTenant}>
            <div
              className={`card text-white mb-3 bg-${tenant.theme} ${classes.TenantCard}`}
              onClick={() => this.handleSelectTenant(tenant)}
            >
              <div className="card-header">Empresa</div>
              <div className="card-body">
                <h5 className="card-title">{tenant.name}</h5>
                <p className="card-text">
                  Da clic acá para ingresar al módulo de esta compañia
                </p>
              </div>
            </div>
          </div>
        );
      })
    ) : (
      <div>No hay ninguna empresa creada actualmente</div>
    );

    return (
      <>
        <SiigoNavbar />
        <div className="container mt-3">
          {this.props.activeTenant.idTenant && <Redirect to="/active-tenant" />}
          <h2>Bienvenido</h2>
          <p>Por favor elija su empresa para continuar</p>
          <div className="row">{tenantsJsx}</div>
          <hr />
          <CreateTenantForm onCreateTenant={this.handleCreateTenant} />
        </div>
      </>
    );
  }
}

const mapStateToProps = state => {
  return {
    tenants: state.tenant.tenantsList,
    activeTenant: state.tenant.activeTenant
  };
};

const mapDispatchToProps = dispatch => {
  return {
    fetchTenants: () => dispatch(actions.fetchTenants()),
    createTenant: (name, theme) => dispatch(actions.createTenant(name, theme)),
    setActiveTenant: tenant => dispatch(actions.setActiveTenant(tenant))
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Tenant);
