import React, { Component } from "react";

class ProductCreate extends Component {
  state = {
    name: "",
    description: "",
    price: 0
  };

  handleNameChange = e => {
    this.setState({ name: e.target.value });
  };

  handleDescriptionChange = e => {
    this.setState({ description: e.target.value });
  };

  handlePriceChange = e => {
    this.setState({ price: e.target.value });
  };

  onClickCreateProduct = () => {
    this.props.onCreateProduct(
      this.state.name,
      this.state.description,
      this.state.price
    );
  };

  render() {
    return (
      <>
        <div className="form-group">
          <label for="name">Nombre</label>
          <input
            type="text"
            className="form-control"
            id="nombre"
            value={this.state.Name}
            onChange={this.handleNameChange}
          />
        </div>
        <div className="form-group">
          <label for="descripcion">Descripcion</label>
          <input
            type="text"
            className="form-control"
            id="description"
            value={this.state.description}
            onChange={this.handleDescriptionChange}
          />
        </div>
        <div className="form-group">
          <label for="name">Precio</label>
          <input
            type="number"
            className="form-control"
            id="precio"
            value={this.state.price}
            onChange={this.handlePriceChange}
          />
        </div>
        <button className="btn btn-primary" onClick={this.onClickCreateProduct}>
          Crear
        </button>
      </>
    );
  }
}

export default ProductCreate;
