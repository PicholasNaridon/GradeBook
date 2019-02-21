import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';
import logo from '../Assets/Images/frontline-logo-white.png'

export class NavMenu extends Component {
  constructor(props){
    super(props)
    this.state ={}

    this.logout = this.logout.bind(this)
  }

  logout(){
    console.log("test")
    localStorage.clear();
    window.location.href = '/';
  } 
  
  render() {
    return (
      <Navbar fixedTop fluid collapseOnSelect>
        <Navbar.Header>
            <Link to={'/'}><img src={logo} alt='logo' /></Link>
          <Navbar.Toggle />
        </Navbar.Header>
        <Navbar.Collapse>
          <Nav>
            <LinkContainer to={'/'} exact>
              <NavItem>
                <Glyphicon glyph='home' /> Home
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/Teacher'}>
              <NavItem>
                <Glyphicon glyph='th-list' /> Courses
              </NavItem>
            </LinkContainer>
            <LinkContainer to={'/Student'}>
              <NavItem>
                <Glyphicon glyph='education' /> Students
              </NavItem>
            </LinkContainer>
            <NavItem onClick={this.logout}>
              <Glyphicon glyph='user' /> Logout
            </NavItem>
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}
