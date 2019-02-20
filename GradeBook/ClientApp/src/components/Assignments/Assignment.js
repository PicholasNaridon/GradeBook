import React, { Component } from 'react'
import HeadingOne from '../Generics/HeadingOne'
import HeadingTwo from '../Generics/HeadingTwo'
import AssignmentGrades from './AssignmentGrades'

class Assignment extends Component {
    constructor(props){
        super(props)
        this.state = {
            isLoading: true,
            assignment: {}
        }
    }

    componentDidMount(){
        fetch(`/api/assignments/${this.props.match.params.id}/grades`)
            .then(response => response.json())
            .then(data => {
                this.setState({
                    isLoading: false,
                    assignment: data
                })
            })
    }
    render () {
        var isLoading = this.state.isLoading

        if (!isLoading){
            return (
                <div>
                    <HeadingOne>{this.state.assignment.name}</HeadingOne>
                    <HeadingTwo>{this.state.assignment.type}</HeadingTwo>
                    <AssignmentGrades grades={this.state.assignment.grades} />
                </div>
            )
        }else {
            return (
                <div></div>
            )
        }
    }
}

export default Assignment