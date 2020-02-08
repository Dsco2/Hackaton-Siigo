import React, { Component } from "react";
import TenantNavbar from "../../components/Navbar/TenantNavbar";
import FileInput from "../../components/UI/FileInput";
import axios from "axios";

class Products extends Component {
  state = {
    file: {}
  };

  fileHandler = event => {
    console.log(event.target.files[0]);
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

  render() {
    return (
      <>
        <TenantNavbar />
        <h1>hello world from Products</h1>

        <FileInput
          onChange={this.fileHandler}
          onUpload={this.onUploadHandler}
          loading={false}
        />
      </>
    );
  }
}

export default Products;
