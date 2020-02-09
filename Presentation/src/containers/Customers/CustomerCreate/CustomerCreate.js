import React, { Component } from "react";

class CostumerCreate extends Component {

    state = {
        name: "",
        lastName: ""
      };
    
      handleNameChange = e => {
        this.setState({ name: e.target.value });
      };

      handleLastNameChange = e => {
        this.setState({ lastName: e.target.value });
      };

    onClickCreateCustomer = () => {
        this.props.onCreateCustomer(this.state.name, this.state.lastName);
        
      };

  render() {
    return (
      <div>
        <div className="form-group">
          <label for="name">Nombre</label>
          <input
            type="text"
            className="form-control"
            id="name"
            value={this.state.name}
            onChange={this.handleNameChange}
          />
        </div>
        <div className="form-group">
          <label for="descripcion">Apellido</label>
          <input
            type="text"
            className="form-control"
            id="description"
            value={this.state.lastName}
            onChange={this.handleLastNameChange}
          />
        </div>
        <button
            className="btn btn-primary"
            onClick={this.onClickCreateCustomer}
          >
            Crear
          </button>
      </div>
    );
  }
}

export default CostumerCreate;
