﻿import React, { Component } from 'react';
import HeadingTwo from '../Generics/HeadingTwo'
import ReactLoading from 'react-loading';
import CourseStudents from './CourseStudents'

export class CourseMain extends Component {
    constructor(props) {
        super(props);
        this.state = {
            isLoading: true,
            course: {}
        }
    }

    componentDidMount() {
        var that = this
        setTimeout(function () {
            fetch(`api/teacher/1/courses/details/${that.props.match.params.id}`)
                .then(response => response.json())
                .then(data => {
                    console.log(data)
                    that.setState({
                        isLoading: false,
                        course: data
                    });
                });
        }, 500)
        

    }


    render() {
        const isLoading = this.state.isLoading
        console.log(this.state)
        if (!isLoading) {
            return (
                <div>
                    <HeadingTwo>{this.state.course.name}</HeadingTwo>
                    <h4>Students</h4>
                    <CourseStudents students={this.state.course.studentCourses} />
                </div>  
                
            )
        } else {
            return <ReactLoading type="spokes" color="#7e4082" height={'20%'} width={'20%'} />
        }
    }
}
