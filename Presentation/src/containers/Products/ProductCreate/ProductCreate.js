import React, { Component } from "react";

class ProductCreate extends Component {
  render() {
    return (
      <form>
        <div className="form-group">
          <label for="name">Nombre</label>
          <input type="text" className="form-control" id="name" />
        </div>
        <div className="form-group">
          <label for="descripcion">Descripcion</label>
          <input type="text" className="form-control" id="descripcion" />
        </div>
        <div className="form-group">
          <label for="name">Precio</label>
          <input type="text" className="form-control" id="precio" />
        </div>
        <button className="btn btn-primary">Crear Producto</button>
      </form>
    );
  }
}

export default ProductCreate;
