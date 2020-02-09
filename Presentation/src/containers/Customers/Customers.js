import React, { Component } from "react";
import TenantNavbar from "../../components/Navbar/TenantNavbar";
import CustomerSearch from "./CustomerSearch/CustomerSearch";
import Card from "../../components/UI/Card";
import CustomerCreate from "./CustomerCreate/CustomerCreate";
import CustomerList from "./CustomerList/CustomerList";


class Customers extends Component {
  state = {
  };

  onSubmitHandler = async event => {
    debugger;
    console.log(event);
    
    // event.preventDefault();

    // if (this.props.restaurant.name && this.props.restaurant.adminEmail) {
    //     await this.props.createRestaurant(this.props.restaurant);
    //     this.setState({ show: true });
    // } else {
    //     this.setState({
    //         show: true,
    //         error: 'Todos los campos son obligatorios'
    //     });
    // }
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
                onSubmit={this.onSubmitHandler}
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


export default Customers;
