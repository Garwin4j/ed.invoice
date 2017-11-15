import React, {Component} from 'react';
import Links from './Links.js'

export default class SideBar extends Component{

    render(){
        return(
            <nav class="col-sm-3 col-md-2 d-none d-sm-block bg-light sidebar">
                <Links class="nav nav-pills flex-column"></Links>
          </nav>
        );
    }
}

