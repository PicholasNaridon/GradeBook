import React, { Component } from 'react';
import HeadingOne from './Generics/HeadingOne'
import HeadingTwo from './Generics/HeadingTwo'
import Login from './Auth/Login'


class Home extends Component {

  render() {
    return (
        <div>
            <HeadingOne>Welcome to</HeadingOne>
            <HeadingTwo>Gradebook</HeadingTwo>
        </div>
    );
  }
}

export default Home
