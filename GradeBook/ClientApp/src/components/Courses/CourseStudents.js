import React, { Component } from 'react';
import { CourseMain } from './CourseMain';


class CourseStudents extends Component {
    constructor(props) {
        super(props);
        this.state = {

        }
    }

    render() {
        return (
            <div>
                {
                    this.props.students.map(function (student) {
                        return (
                            <div key={student.student.id} student={student.student}>
                                {student.student.firstName} {student.student.lastName}
                            </div>
                        )
                    })
                }
            </div>
        )
        
    }
}
export default CourseStudents