import React from 'react';

import Navigation from './Navigation';

export default class Layout extends React.Component {
    render() {
        console.log('props from layout', this.props.children);
    return (
      <section>
        <Navigation />
            <section className="container">
            <br/><br/>     
          {this.props.children}
        </section>
      </section>
    );
  }
}