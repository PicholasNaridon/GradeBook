import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import {Home } from './components/Home'
import { TeacherIndex } from './components/Teacher/TeacherIndex'
import { StudentIndex } from './components/Student/StudentIndex'


export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/Teacher' component={TeacherIndex} />
        <Route path='/Student' component={StudentIndex} />
      </Layout>
    );
  }
}
