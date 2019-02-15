import React from 'react';

const hStyling = {
    color: '#7e4082',
    fontWeight: 700,
    fontFamily : "'Lato',sans-serif'"
}


export default function HeadingOne (props) {
    return (<h1 style={hStyling}>{props.children}</h1> );
}