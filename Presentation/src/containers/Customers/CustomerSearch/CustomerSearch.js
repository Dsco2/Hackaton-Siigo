import React, { Component } from "react";
import Autosuggest from "react-autosuggest";
import "./CustomerSearch.css";
import { connect } from "react-redux";
import * as actions from "../../../store/actionCreators";
import AwesomeDebouncePromise from "awesome-debounce-promise";
import axios from "axios";

class CustomerSearch extends Component {
  state = {
    value: "",
    suggestions: []
  };

  componentDidMount() {
    const activeTenantId = this.props.idTenant;
    this.props.fetchCustomers(activeTenantId);
  }

  onChangeAutosuggest = async (_, { newValue }) => {
    // This updates the input value of the search input
    await this.setState({ value: newValue });

    // We update the suggestions to get data in real time, using debouncing to avoid flooding the API with requests after every keystroke
    const activeTenantId = this.props.idTenant;
    const searchAPI = data => axios.post("/Customers/search-customers", data);
    const searchCustomersDebounced = AwesomeDebouncePromise(searchAPI, 500);
    const data = { id: activeTenantId, query: newValue };
    const result = await searchCustomersDebounced(data);
    if (result.status === 200) {
      this.props.updateCustomers(result.data);
    }
  };

  // Get in suggestions all strings that include the input
  getSuggestions = value => {
    const inputValue = value.trim().toLowerCase();
    const inputLength = inputValue.length;

    return inputLength === 0
      ? []
      : this.props.customers.filter(
          custo =>
            custo.firstName.toLowerCase().includes(inputValue) ||
            custo.lastName.toLowerCase().includes(inputValue)
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

  getSelectedCustomer = idCustomer => {
    this.props.selectCustomer(idCustomer);
  };

  render() {
    const getSuggestionValue = suggestion => {
      console.log(suggestion);
      return suggestion.firstName;
    };

    const renderSuggestion = suggestion => {
      return (
        <div onClick={() => this.getSelectedCustomer(suggestion.idCustomer)}>
          {`${suggestion.firstName} ${suggestion.lastName}`}
        </div>
      );
    };

    const value = this.state.value;

    const inputProps = {
      placeholder: "Ingresa un cliente a buscar",
      value,
      onChange: this.onChangeAutosuggest
    };

    return (
      <Autosuggest
        suggestions={this.state.suggestions}
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
    customers: state.customer.customersToSearch
  };
};

const mapDispatchToProps = dispatch => {
  return {
    fetchCustomers: idTenant => dispatch(actions.fetchCustomers(idTenant)),
    selectCustomer: idCustomer => dispatch(actions.selectCustomer(idCustomer)),
    updateCustomers: customerList =>
      dispatch(actions.updateCustomers(customerList))
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(CustomerSearch);
