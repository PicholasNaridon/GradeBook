import React, { Component } from 'react';

class StudentIndex extends Component {

  constructor(props) {
    super(props);
   
  }



  render() {
    return (
      <div>
        <h1>Welcome {this.props.name}</h1>

      </div>
    );
  }
}

export default StudentIndex