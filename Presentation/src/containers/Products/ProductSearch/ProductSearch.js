import React, { Component } from "react";
import Autosuggest from "react-autosuggest";
import "./ProductSearch.css";
import { connect } from "react-redux";
import * as actions from "../../../store/actionCreators";
import AwesomeDebouncePromise from "awesome-debounce-promise";
import axios from "axios";

class ProductSearch extends Component {
  state = {
    value: "",
    suggestions: []
  };

  componentDidMount() {
    const activeTenantId = this.props.idTenant;
    this.props.fetchProducts(activeTenantId);
  }

  onChangeAutosuggest = async (_, { newValue }) => {
    // This updates the input value of the search input
    await this.setState({ value: newValue });

    // We update the suggestions to get data in real time, using debouncing to avoid flooding the API with requests after every keystroke
    const activeTenantId = this.props.idTenant;
    const searchAPI = data => axios.post("/Products/search-products", data);
    const searchProductsDebounced = AwesomeDebouncePromise(searchAPI, 500);
    const data = { id: activeTenantId, query: newValue };
    const result = await searchProductsDebounced(data);
    if (result.status === 200) {
      this.props.updateProducts(result.data);
    }
  };

  // Get in suggestions all strings that include the input
  getSuggestions = value => {
    const inputValue = value.trim().toLowerCase();
    const inputLength = inputValue.length;

    return inputLength === 0
      ? []
      : this.props.products.filter(prod =>
          prod.name.toLowerCase().includes(inputValue)
        );
  };

  onSuggestionsFetchRequested = ({ value }) => {
    this.setState({
      suggestions: this.getSuggestions(value)
    });
  };

  onSuggestionsClearRequested = () => {
    this.setState({
      suggestions: []
    });
  };

  render() {
    const getSuggestionValue = suggestion => suggestion.name;

    const renderSuggestion = suggestion => <div>{suggestion.name}</div>;
    const { value, suggestions } = this.state;

    const inputProps = {
      placeholder: "Ingresa un producto a buscar",
      value,
      onChange: this.onChangeAutosuggest
    };

    return (
      <Autosuggest
        suggestions={suggestions}
        onSuggestionsFetchRequested={this.onSuggestionsFetchRequested}
        onSuggestionsClearRequested={this.onSuggestionsClearRequested}
        getSuggestionValue={getSuggestionValue}
        renderSuggestion={renderSuggestion}
        inputProps={inputProps}
      />
    );
  }
}

const mapStateToProps = state => {
  return {
    idTenant: state.tenant.activeTenant.idTenant,
    products: state.product.productsToSearch
  };
};

const mapDispatchToProps = dispatch => {
  return {
    fetchProducts: idTenant => dispatch(actions.fetchProducts(idTenant)),
    updateProducts: productList => dispatch(actions.updateProducts(productList))
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(ProductSearch);
