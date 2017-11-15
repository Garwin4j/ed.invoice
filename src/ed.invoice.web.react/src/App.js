import React, { Component } from 'react';
import {BrowserRouter} from 'react-router-dom';
import logo from './logo.svg';
import './App.css';

import TopNav from './layout/TopNav.js';
import MainContent from './layout/MainContent.js';

class App extends Component {
  render() {
    return (
      <BrowserRouter>
        <div class="invoicey">
          <TopNav></TopNav>
          <MainContent></MainContent> 
        </div>
      </BrowserRouter>
    );
  }
}

export default App;
