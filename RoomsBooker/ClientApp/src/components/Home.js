import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Hello</h1>
        <p>Welcome to Reservation App</p>
            <ul>
                <li><a href='/swagger/index.html' target="_blank">Swagger UI</a></li>
        </ul>
      </div>
    );
  }
}
