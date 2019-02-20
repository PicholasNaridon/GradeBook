import React, { Component } from 'react';
import { Col, Grid, Row } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import Login from './Auth/Login'

export class Layout extends Component {
  constructor(props){
    super(props)
    this.state = {
      loggedIn: false,
      user: {}
    }

    this.handleLogin = this.handleLogin.bind(this)
  }

  componentDidMount(){
    try{
      var user = JSON.parse(localStorage.user)
      this.setState({
        user: user,
        loggedIn: true
      })
    }catch(err){
      this.setState({
        loggedIn: false
      })
    }
  }

  handleLogin(){
    this.setState({
      loggedIn: true
    })
  }

  render() {
    var isLoggedIn = this.state.loggedIn

    if (isLoggedIn){
      return (
        <Grid fluid>
          <Row>
            <Col sm={3}>
              <NavMenu />
            </Col>
            <Col sm={9}>
              {this.props.children}
            </Col>
          </Row>
        </Grid>
      );
    }else{
      return (
        <Login handleLogin={this.handleLogin} />
      )
    }
  }
}
