import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';
import logo from '../Assets/Images/frontline-logo-white.png'

export class NavMenu extends Component {
  displayName = NavMenu.name

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
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    );
  }
}
