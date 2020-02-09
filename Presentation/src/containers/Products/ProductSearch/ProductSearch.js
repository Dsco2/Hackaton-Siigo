import React, { Component } from "react";
import Autosuggest from "react-autosuggest";
import "./ProductSearch.css";

class ProductSearch extends Component {
  state = {
    value: "",
    languages: [
      {
        name: "C",
        year: 1972
      },
      {
        name: "Clojure",
        year: 1972
      },
      {
        name: "Elm",
        year: 2012
      }
    ],
    suggestions: []
  };

  onChangeAutosuggest = (e, { newValue }) => {
    this.setState({ value: newValue });
  };

  // Teach Autosuggest how to calculate suggestions for any given input value.
  getSuggestions = value => {
    const inputValue = value.trim().toLowerCase();
    const inputLength = inputValue.length;

    return inputLength === 0
      ? []
      : this.state.languages.filter(
          lang => lang.name.toLowerCase().slice(0, inputLength) === inputValue
        );
  };

  onSuggestionsFetchRequested = ({ value }) => {
    this.setState({
      suggestions: this.getSuggestions(value)
    });
  };

  // Autosuggest will call this function every time you need to clear suggestions.
  onSuggestionsClearRequested = () => {
    this.setState({
      suggestions: []
    });
  };
  render() {
    // Imagine you have a list of languages that you'd like to autosuggest.

    // When suggestion is clicked, Autosuggest needs to populate the input
    // based on the clicked suggestion. Teach Autosuggest how to calculate the
    // input value for every given suggestion.
    const getSuggestionValue = suggestion => suggestion.name;

    // Use your imagination to render suggestions.
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

export default ProductSearch;
