import React, { Component } from 'react';
import {TeacherCourseList} from './TeacherCourseList'

export class TeacherIndex extends Component {

    constructor(props) {
        super(props);
        this.state = {
            teacher: {},
            loading: true
        };
    }

    componentDidMount() {
        fetch('api/teacher/2/Courses/Index')
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

        isLoading 
            return (
                <div>
                    <h1> Welcome {isLoading ? '' : this.state.teacher.firstName }</h1>
                    <div> {isLoading ? '' : <TeacherCourseList courses={this.state.teacher.courses} />}</div>
                </div>
        );
        : 
        return
    }
}
