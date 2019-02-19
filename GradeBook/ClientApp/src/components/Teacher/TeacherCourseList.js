import React, { Component } from 'react';
import HeadingTwo from '../Generics/HeadingTwo';
import { Route } from 'react-router';
import { Link } from 'react-router-dom';

import CourseMain from '../Courses/CourseMain'


export class TeacherCourseList extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <HeadingTwo> My Classes </HeadingTwo>
                {
                    this.props.courses.map(function(course) {
                        return (
                            <div key={course.id}>
                                <Link to={'/courses/' + course.id}>{course.name}</Link>
                            </div>    
                        )
                    })
                }
            </div>
        );
    }
}

