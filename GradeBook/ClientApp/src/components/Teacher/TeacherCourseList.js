import React, { Component } from 'react';
import Heading from '../Generics/Heading'
export class TeacherCourseList extends Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <Heading name={"Course List"} />
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

