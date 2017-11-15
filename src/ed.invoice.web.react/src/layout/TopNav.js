import React, { Component } from 'react';
import { Link, Router, Route, Switch } from 'react-router-dom';
import Links from './Links.js'
class TopNav extends Component {
    constructor()
    {
        super();
    }

    render(){
        return(
            <header>
            <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
              <a class="navbar-brand" href="http://getbootstrap.com/docs/4.0/examples/dashboard/#">Invoicey</a>
              <button class="navbar-toggler d-lg-none" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>
      
              <div class="collapse navbar-collapse" id="menuLinks">
                <Links class="navbar-nav mr-auto"></Links>
              </div>
            </nav>
          </header>
        );
    }
}

export default TopNav;