import React, { Component } from "react";
import TenantNavbar from "../../components/Navbar/TenantNavbar";
import FileInput from "../../components/UI/FileInput";
import axios from "axios";
import ProductSearch from "./ProductSearch/ProductSearch";
import Card from "../../components/UI/Card";
import ProductCreate from "./ProductCreate/ProductCreate";
import ProductList from "./ProductList/ProductList";

class Products extends Component {
  state = {
    file: {},
    showProductCreate: false
  };

  fileHandler = event => {
    this.setState({ file: event.target.files[0] });
  };

  onUploadHandler = event => {
    event.preventDefault();
    debugger;
    const data = {
      idTenant: 3,
      file: this.state.file
    };
    axios
      .post("products/upload-file", data)
      .then(response => response)
      .catch(error => error);
  };

  onClickProdCreateToggle = () => {
    debugger;
    const updatedState = !this.state.showProductCreate;

    this.setState({ showProductCreate: updatedState });
  };

  render() {
    const show = this.state.showProductCreate;

    return (
      <>
        <TenantNavbar />
        <div className="container">
          <h2 className="mt-4">Módulo de Productos</h2>
          <div className="row mt-4">
            <div className="col-12 col-md-6">
              <Card header="Búsqueda" title="Búsqueda de productos">
                <p>
                  Se guardará el historial de búsquedas para realizar
                  sugerencias personalizadas.
                </p>
                <ProductSearch />
              </Card>
            </div>
            <div className="col-12 col-md-6">
              <Card header="Creación" title="Creación Masiva">
                <FileInput
                  onChange={this.fileHandler}
                  onUpload={this.onUploadHandler}
                  loading={false}
                />
                <hr />
                <h5>
                  Creación Manual
                  <button
                    className="pl-4 btn btn-link"
                    onClick={this.onClickProdCreateToggle}
                  >
                    {show ? "Ocultar " : "Ver "}
                    formulario
                  </button>
                </h5>
                {show && <ProductCreate />}
              </Card>
            </div>
          </div>
          <div className="row mt-4">
            <div className="col-12">
              <Card header="Listado" title="Todos los productos">
                <ProductList />
              </Card>
            </div>
          </div>
        </div>
      </>
    );
  }
}

export default Products;
