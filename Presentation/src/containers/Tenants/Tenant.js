import React, { Component } from "react";
import SiigoNavbar from "../../components/Navbar/SiigoNavbar";
import CreateTenantForm from "../../components/Tenants/CreateTenantForm";
import { connect } from "react-redux";
import * as actions from "../../store/actionCreators";

class Tenant extends Component {
  state = {
    themes: [
      "primary",
      "secondary",
      "success",
      "danger",
      "warning",
      "info",
      "dark"
    ],
    tenants: [
      {
        id: 1,
        name: "Exito",
        theme: "warning"
      },
      {
        id: 2,
        name: "Jumbo",
        theme: "success"
      },
      {
        id: 3,
        name: "Cueros SAS",
        theme: "info"
      }
    ]
  };

  componentDidMount() {
    this.props.fetchTenants();
  }

  render() {
    const tenantsJsx = this.state.tenants.map(tenant => {
      return (
        <div className="col-12 col-md-4" key={tenant.id}>
          <div
            className={`card text-white mb-3 bg-${tenant.theme}`}
            style={{ maxWidth: "18rem" }}
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
    });

    return (
      <>
        <SiigoNavbar />
        <div className="container mt-3">
          <h2>Bienvenido</h2>
          <p>Por favor elija su empresa para continuar</p>
          <div className="row">{tenantsJsx}</div>
          <hr />
          <CreateTenantForm themes={this.state.themes} />
        </div>
      </>
    );
  }
}

const mapStateToProps = state => {
  return {
    tenants: state.tenant.tenantsList
  };
};

const mapDispatchToProps = dispatch => {
  return {
    fetchTenants: () => dispatch(actions.fetchTenants())
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(Tenant);
