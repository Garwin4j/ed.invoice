import React, {Component} from 'react';
import {Route} from 'react-router-dom';
import SideBar from "./SideBar.js";
import Dashboard from '../Dashboard/Dashboard.js';

class MainContent extends Component{

    render(){
        return(
            <div class="container-fluid">
            <div class="row">
            <SideBar></SideBar>
              <main role="main" class="col-sm-9 ml-sm-auto col-md-10 pt-3">
              <Route exact path="/" component={Dashboard}/>
              <Route path="/Dashboard" component={Dashboard}/>
              </main>
            </div>
          </div>
        );
    }
}

export default MainContent;