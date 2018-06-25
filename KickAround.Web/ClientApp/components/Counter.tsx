import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { observer } from 'mobx-react';
import { observable } from 'mobx';

interface CounterState {
    currentCount: number;
}

@observer
export class Counter extends React.Component<RouteComponentProps<{}>, CounterState> {
    @observable public count: number;

    constructor() {
        super();
        this.state = { currentCount: 0 };
        this.count = 3;
    }

    public render() {
        return <div>
            <h1>Counter</h1>

            <p>This is a simple example of a React component.</p>

            <p>Current count: <strong>{ this.state.currentCount }</strong></p>

            <button onClick={() => { this.incrementCounter(); } }>Increment</button>
        </div>;
    }

    public incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }
}
