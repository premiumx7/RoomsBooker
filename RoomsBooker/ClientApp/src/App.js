import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { ManagerView } from './components/ManagerView';
import { Reservation } from './components/Reservation';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
            <Route path='/ManagerView' component={ManagerView} />
            <Route path='/Reservation' component={Reservation} />
      </Layout>
    );
  }
}
