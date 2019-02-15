import React, { Component } from 'react';
import HeadingTwo from '../Generics/HeadingTwo';


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
                                <a href={'/courses/' + course.id}>{course.name}</a>
                            </div>    
                        )
                        })}
            </div>
        );
    }
}

