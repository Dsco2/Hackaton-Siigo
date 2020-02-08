import React, { Component } from "react";
import * as classes from "./CreateTenant.module.css";

class CreateTenantForm extends Component {
  state = {
    name: "",
    themes: [
      "primary",
      "secondary",
      "success",
      "danger",
      "warning",
      "info",
      "dark"
    ],
    selectedTheme: "primary",
    errorMessage: ""
  };

  handleNameChange = e => {
    this.setState({ name: e.target.value });
  };

  onClickCreateTenant = () => {
    if (!this.state.name) {
      this.setState({ errorMessage: "El nombre de su empresa es obligatorio" });
    } else {
      this.setState({ errorMessage: "" });
      this.props.onCreateTenant(this.state.name, this.state.selectedTheme);
    }
  };

  onClickTheme = theme => {
    this.setState({ selectedTheme: theme });
  };

  render() {
    const themesJsx = this.state.themes.map(theme => (
      <li
        key={theme}
        onClick={() => this.onClickTheme(theme)}
        className={`${
          this.state.selectedTheme === theme ? classes.Selected : ""
        } pb-1 px-2`}
      >
        <i className={`fa fa-square text-${theme}`}></i>
      </li>
    ));

    return (
      <div className="card">
        <h5 className="card-header">¿No encuentra su empresa?</h5>
        <div className="card-body">
          <h5 className="card-title">Crear nueva empresa</h5>
          <div className="card-text">
            {this.state.errorMessage && (
              <div className="alert alert-danger">
                {this.state.errorMessage}
              </div>
            )}
            <div className="row">
              <div className="col">
                <div className="form-group">
                  <label htmlFor="exampleInputEmail1">Ingrese el nombre</label>
                  <input
                    type="email"
                    className="form-control"
                    id="exampleInputEmail1"
                    aria-describedby="emailHelp"
                    value={this.state.name}
                    onChange={this.handleNameChange}
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
          <button
            className="btn btn-primary"
            onClick={this.onClickCreateTenant}
          >
            Crear
          </button>
        </div>
      </div>
    );
  }
}

export default CreateTenantForm;
