import React from "react";
const CustomerCreate = ({ onSubmit, name, lastName }) => {
  return (
    <form onSubmit={onSubmit}>
      <div className="form-group">
        <label htmlFor="name">Nombre</label>
        <input type="text" className="form-control" id="name" value={name} />
      </div>
      <div className="form-group">
        <label htmlFor="descripcion">Apellido</label>
        <input
          type="text"
          className="form-control"
          id="descripcion"
          value={lastName}
        />
      </div>
      <button className="btn btn-primary">Ingresar Cliente</button>
    </form>
  );
};

export default CustomerCreate;
