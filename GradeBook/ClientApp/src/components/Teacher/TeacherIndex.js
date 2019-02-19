import React, { Component } from 'react';
import {TeacherCourseList} from './TeacherCourseList'
import HeadingOne from '../Generics/HeadingOne';
import  ReactLoading  from 'react-loading'

export class TeacherIndex extends Component {

    constructor(props) {
        super(props);
        this.state = {
            teacher: {},
            loading: true
        };
    }

    componentDidMount() {
        fetch('api/teacher/1/Courses/all')
            .then(response => response.json())
            .then(data => {
                this.setState({
                    teacher: data[0],
                    loading: false
                });
            });

    }

    render() {
        const isLoading = this.state.loading

        if (!isLoading) {
            return (
                <div>
                    <HeadingOne> Welcome {this.state.teacher.firstName}!</HeadingOne>
                    <div>

                        <TeacherCourseList courses={this.state.teacher.courses} />

                    </div>
                </div>
            )
        } else {
            return (
                <ReactLoading type="spokes" color="#7e4082" height={'20%'} width={'20%'} />
            )
        }
        
    }
}
