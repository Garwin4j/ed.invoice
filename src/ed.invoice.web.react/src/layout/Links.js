import React, {Component} from 'react';
import {Link} from 'react-router-dom';

export default class Links extends Component{
    constructor(props){
        super(props);

    }
    render(){
        return(
            <ul className={this.props.class }>
            <li className="nav-item active">
              <Link className="nav-link" to="/Dashboard" >Dashboard <span class="sr-only">(current)</span></Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/Contacts" >Contacts</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/Invoices" >Invoices</Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link" to="/Items" >Items</Link>
            </li>
          </ul>
        );
    }

}