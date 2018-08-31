
import * as React from 'react';

interface BuggyCounterState {
  counter: number;
}

export class BuggyCounter extends React.Component<{}, BuggyCounterState> {
  constructor(props) {
    super(props);
    this.state = { counter: 0 };
    this.handleClick = this.handleClick.bind(this);
  }

  public handleClick() {
    this.setState(({ counter }) => ({
      counter: counter + 1
    }));
  }

  public render() {
    if (this.state.counter === 5) {
      // Simulate a JS error
      throw new Error('I crashed!');
    }
    return <h1 onClick={this.handleClick}>{this.state.counter}</h1>;
  }
}