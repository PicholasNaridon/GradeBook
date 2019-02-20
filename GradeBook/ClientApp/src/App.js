import React, { Component } from 'react';
import { Route } from 'react-router';
import {Layout} from './components/Layout';
import Home  from './components/Home'
import  TeacherIndex  from './components/Teacher/TeacherIndex'
import  StudentIndex  from './components/Student/StudentIndex'
import  CourseMain  from './components/Courses/CourseMain'
import  Assignment  from  './components/Assignments/Assignment'
import  Login  from './components/Auth/Login'

export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path="/Login" component={Login} />
        <Route path='/Teacher' component={TeacherIndex} />
        <Route path='/Student' component={StudentIndex} />
        <Route path='/courses/:id' component={CourseMain} />
        <Route path='/assignment/:id' component={Assignment} />
      </Layout>
    );
  }
}
