import React, { Component } from 'react'

class AssignmentGrades extends Component {
    constructor(props){
        super(props)
    }
    render () {
        console.log('GRADEs', this.props.grades)
        return (
            <div>
                <table  style={{width: '100%'}}>
                    <tr>
                        <th>
                            Name
                        </th>
                        <th>
                            Percentage (%)
                        </th>
                        <th>
                            Letter Grade
                        </th>
                        <th>
                            Date
                        </th>
                    </tr>
                    {this.props.grades.map(function(grade){
                        return(
                            <tr key={grade.id}>
                                <td>{grade.student.firstName} {grade.student.lastName}</td>
                                <td>{grade.numGrade}</td>
                                <td>{grade.letterGrade}</td>
                                <td>{grade.addedDate}</td>
                            </tr>
                        )
                    })}
                </table>
            </div>
        )
    }
}

export default AssignmentGrades