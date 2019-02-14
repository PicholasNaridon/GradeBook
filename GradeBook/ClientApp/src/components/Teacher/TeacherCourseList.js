import React, { Component } from 'react';

export class TeacherCourseList extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                {
                    this.props.courses.map(function(course) {
                        return (
                            <div key={course.id}>{course.name}</div>    
                        )
                        })}
            </div>
        );
    }
}

