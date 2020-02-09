import React, { Component } from "react";
import TenantNavbar from "../../components/Navbar/TenantNavbar";
import CustomerSearch from "./CustomerSearch/CustomerSearch";
import Card from "../../components/UI/Card";
import CustomerCreate from "./CustomerCreate/CustomerCreate";
import CustomerList from "./CustomerList/CustomerList";
import axios from "axios";
import { connect } from "react-redux";

class Customers extends Component {
  state = {
  };

  handleCreateCustomer = (name, lastName) => {

    let data = {firstName: name,
       lastName: lastName,
        idtenant: this.props.idTenant}

    console.log(data);
    axios
      .post("customers/createCustomer", data)
      .then(response => response)
      .catch(error => error);
  };
  render() {
    return (
      <>
        <TenantNavbar />
        <div className="container">
          <h2 className="mt-4">Módulo de Clientes</h2>
          <div className="row mt-4">
            <div className="col-12 col-md-6">
              <Card header="Búsqueda" title="Búsqueda de clientes">
                <p>
                  Se guardará el historial de búsquedas para realizar
                  sugerencias personalizadas.
                </p>
                <CustomerSearch />
              </Card>
            </div>
            <div className="col-12 col-md-6">
              <Card header="Creación">
                <h5>
                  Creación Manual
                </h5>
                {<CustomerCreate 
                  onCreateCustomer={this.handleCreateCustomer}
                 />}
              </Card>
            </div>
          </div>
          <div className="row mt-4">
            <div className="col-12">
              <Card header="Listado" title="Todos los clientes">
                <CustomerList />
              </Card>
            </div>
          </div>
        </div>
      </>
    );
  }
}

const mapStateToProps = state => {
  return {
    idTenant: state.tenant.activeTenant.idTenant
  };
};

export default connect(mapStateToProps)(Customers);
