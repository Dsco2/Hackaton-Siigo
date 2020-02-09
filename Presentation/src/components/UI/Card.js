import React from "react";

const Card = ({ header, title, children }) => {
  return (
    <div class="card">
      <h5 class="card-header">{header}</h5>
      <div class="card-body">
        <h5 class="card-title">{title}</h5>
        <div class="card-text">{children}</div>
      </div>
    </div>
  );
};

export default Card;
