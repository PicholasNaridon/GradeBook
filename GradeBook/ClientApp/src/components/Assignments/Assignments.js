import React, { Component } from 'react';
import { Link } from 'react-router-dom'

class Assignments extends Component {
    constructor(props) {
        super(props);
        this.state = {
            loading: true,
            assignments: []
        }
    }

    componentDidMount() {
        fetch(`/api/course/${this.props.courseId}/assignments`)
            .then(response => response.json())
            .then(data => {
                console.log(data)
                this.setState({
                    assignments: data.courseAssignments,
                    loading: false
                });
            })
    }


    render() {
        var isLoading = this.state.isLoading

        if (!isLoading) {
            return (
                <div>
                    {this.state.assignments.map(function (assignment) {
                        return (
                            <div key={assignment.id}>
                                <Link to={'/assignment/' + assignment.id}>{assignment.name}</Link>
                            </div>  
                        )
                    })}
                </div>
            )
        }

    }
}
export default Assignments