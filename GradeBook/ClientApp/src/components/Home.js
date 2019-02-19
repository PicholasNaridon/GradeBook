import React, { Component } from 'react';
import HeadingOne from './Generics/HeadingOne'
import HeadingTwo from './Generics/HeadingTwo'

export class Home extends Component {
  displayName = Home.name

  render() {
    return (
        <div>
            <HeadingOne> GradeBook</HeadingOne>
            <HeadingTwo>Tips</HeadingTwo>
        </div>
    );
  }
}
