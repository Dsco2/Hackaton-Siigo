import React, { Component } from "react";
import TenantNavbar from "../../components/Navbar/TenantNavbar";
import FileInput from "../../components/UI/FileInput";
import axios from "axios";
import ProductSearch from "./ProductSearch/ProductSearch";
import Card from "../../components/UI/Card";
import ProductCreate from "./ProductCreate/ProductCreate";
import { connect } from "react-redux";
import ProductDetail from "./ProductDetail/ProductDetail";

class Products extends Component {
  state = {
    file: {},
    showProductCreate: false,
    showProductEdit: false
  };

  fileHandler = event => {
    this.setState({ file: event.target.files[0] });
  };

  handleCreateProduct = (name, description, price) => {
    let data = {
      name: name,
      description: description,
      listPrice: price,
      idtenant: this.props.idTenant
    };

    axios
      .post("Products/createProduct", data)
      .then(response => response)
      .catch(error => error);
  };

  onUploadHandler = event => {
    event.preventDefault();
    debugger;
    let data = new FormData();
    data.append("idTenant", this.props.idTenant);
    data.append("file", this.state.file);
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

  handleSelectProduct = idProduct => {
    this.setState({ showProductEdit: true });
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
                <ProductSearch onSelectProduct={this.handleSelectProduct} />
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
                {show && (
                  <ProductCreate onCreateProduct={this.handleCreateProduct} />
                )}
              </Card>
            </div>
          </div>
          {this.state.showProductEdit && (
            <div className="row mt-4">
              <div className="col-12">
                <Card header="Edición" title="Editar producto">
                  <ProductDetail product={this.props.activeProduct} />
                </Card>
              </div>
            </div>
          )}
        </div>
      </>
    );
  }
}
const mapStateToProps = state => {
  return {
    idTenant: state.tenant.activeTenant.idTenant,
    activeProduct: state.product.activeProduct
  };
};

export default connect(mapStateToProps)(Products);
