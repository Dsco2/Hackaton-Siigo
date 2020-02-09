import React, { Component } from "react";

class ProductDetail extends Component {
  render() {
    const product = this.props.product;
    return (
      <>
        <div className="form-group">
          <label htmlFor="name">Nombre</label>
          <input
            type="text"
            className="form-control"
            id="nombre"
            value={product.name}
          />
        </div>
        <div className="form-group">
          <label htmlFor="descripcion">Descripcion</label>
          <input
            type="text"
            className="form-control"
            id="description"
            value={product.description}
          />
        </div>
        <div className="form-group">
          <label htmlFor="name">Precio</label>
          <input
            type="number"
            className="form-control"
            id="precio"
            value={product.listPrice}
          />
        </div>
        <button className="btn btn-outline-primary">Editar</button>
      </>
    );
  }
}

export default ProductDetail;
