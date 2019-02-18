import React from 'react';

const hStyling = {
    color: '#6bccb3',
    fontWeight: 700,
    fontFamily : "'Lato',sans-serif'"
}


export default function HeadingTwo (props) {
    return (<h2 style={hStyling}>{props.children}</h2> );
}   