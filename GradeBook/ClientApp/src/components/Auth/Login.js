﻿import React, { Component } from 'react'
import HeadingOne from '../Generics/HeadingOne'

class Login extends Component {
    constructor(props) {
        super(props);
        this.state = {
            isStudent: true,
            email: '', 
            password: '',
            message: ''
        }

        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
        this.changeUserType = this.changeUserType.bind(this);
    }
    handleChange(event) {
        this.setState({[event.target.name]: event.target.value});
      }
    handleSubmit(event) {
        event.preventDefault();
        this.Authenticate(this.state.email, this.state.password);
    }

    changeUserType(){
        this.setState({
            isStudent: !this.state.isStudent
        })
    }

    Authenticate(email, password){
        var that = this
        var data ={
            email: email,
            password: password
        }
        var endpoint = this.state.isStudent ? '/studentsAuth/authenticate' : '/teachersAuth/authenticate'
        console.log(endpoint)
        fetch(endpoint, {
            method: 'POST',
            headers: {
                'Content-Type': "application/json"
            },
            body: JSON.stringify(data)
        })
        .then((response) =>{
            if (response.status === 200){
                console.log(response)
                localStorage.setItem("userType", (that.state.isStudent ? 'student' : 'teacher'))
                that.props.handleLogin()
            }else{
                that.setState({
                    message: 'Wrong username or password'
                })
            }
           return response.json()
        })
        .then((data) => {
           localStorage.setItem("user", JSON.stringify(data))
        })
        
    }
    render () {
        var isStudent = this.state.isStudent
        if (isStudent){
            return (
                <div>
                    <HeadingOne>Student login</HeadingOne>
                    <form onSubmit={this.handleSubmit}>
                        <div>{this.state.message}</div>
                        <label for="email">Email</label>
                        <br />
                        <input type="text" id="email" name="email" value={this.state.email} onChange={this.handleChange}/>
                        <br />
                        <label for="password">Password</label>
                        <br />
                        <input type="password" id="password" name="password" value={this.state.password} onChange={this.handleChange}/>
                        <br />
                        <button type="submit"> Login </button>
                    </form>
                    <label>Login as Teacher</label>
                    <br />
                    <button onClick={this.changeUserType}>Teachers</button>
                </div>
            )
        }else {
            return (
                <div>
                    <HeadingOne>Teacher login</HeadingOne>
                    <form onSubmit={this.handleSubmit}>
                        <div>{this.state.message}</div>
                        <label for="email">Email</label>
                        <br />
                        <input type="text" id="email" name="email" value={this.state.email} onChange={this.handleChange}/>
                        <br />
                        <label for="password">Password</label>
                        <br />
                        <input type="password" id="password" name="password" value={this.state.password} onChange={this.handleChange}/>
                        <br />
                        <button type="submit"> Login </button>
                    </form>
                    <label>Login as Student</label>
                    <br />
                    <button onClick={this.changeUserType}>Student</button>
                </div>
            )
        }
       
    }
}

export default Login