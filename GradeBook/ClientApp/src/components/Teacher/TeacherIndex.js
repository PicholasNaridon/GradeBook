import React, { Component } from 'react';
import {TeacherCourseList} from './TeacherCourseList'
import HeadingOne from '../Generics/HeadingOne';
import  ReactLoading  from 'react-loading'

class TeacherIndex extends Component {

    constructor(props) {
        super(props);
        this.state = {
            teacher: {},
            loading: true
        };
    }

    componentDidMount() {
        var user = JSON.parse(localStorage.user)
        console.log(user)
        var that = this
        setTimeout(function () {
            fetch(`api/teacher/${user.id}/Courses/all`)
                .then(response => response.json())
                .then(data => {
                    that.setState({
                        teacher: data[0],
                        loading: false
                    });
                })
        }, 250)


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

export default TeacherIndex