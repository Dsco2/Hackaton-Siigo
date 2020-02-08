import React from "react";
import { Link } from "react-router-dom";

const Navbar = () => {
  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-primary">
      <Link className="navbar-brand" to="/">
        Hackaton SIIGO
      </Link>
      <button
        className="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#navbarSupportedContent"
        aria-controls="navbarSupportedContent"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span className="navbar-toggler-icon"></span>
      </button>

      <div className="collapse navbar-collapse" id="navbarSupportedContent">
        <ul className="navbar-nav mr-auto">
          <li className="nav-item active">
            <Link className="nav-link" to="/">
              Home
            </Link>
          </li>
          <li className="nav-item">
            <Link className="nav-link" to="/upload-data">
              Upload Data
            </Link>
          </li>
          <li className="nav-item">
            <Link className="nav-link" to="/search-customers">
              Search Customers
            </Link>
          </li>
          <li className="nav-item">
            <Link className="nav-link" to="/search-products">
              Search Products
            </Link>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
