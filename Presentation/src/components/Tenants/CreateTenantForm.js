import React from "react";
import * as classes from "./CreateTenant.module.css";

const CreateTenantForm = ({ themes }) => {
  const themesJsx = themes.map(theme => (
    <li key={theme}>
      <i className={`fa fa-square text-${theme}`}></i>
    </li>
  ));

  return (
    <div className="card">
      <h5 className="card-header">¿No encuentra su empresa?</h5>
      <div className="card-body">
        <h5 className="card-title">Crear nueva empresa</h5>
        <div className="card-text">
          <div className="row">
            <div className="col">
              <div className="form-group">
                <label htmlFor="exampleInputEmail1">Ingrese el nombre</label>
                <input
                  type="email"
                  className="form-control"
                  id="exampleInputEmail1"
                  aria-describedby="emailHelp"
                />
                <small id="emailHelp" className="form-text text-muted">
                  Asegurese primero que su empresa no se encuentra ya creada.
                </small>
              </div>
            </div>
            <div className="col">
              <label htmlFor="exampleInputEmail1">
                Elija el color de su empresa
              </label>
              <ul className={`pl-0 ${classes.ThemesList}`}>{themesJsx}</ul>
            </div>
          </div>
        </div>
        <button className="btn btn-primary">Crear</button>
      </div>
    </div>
  );
};

export default CreateTenantForm;
