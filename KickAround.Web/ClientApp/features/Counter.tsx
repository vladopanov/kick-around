import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { observer, inject } from 'mobx-react';
import { observable } from 'mobx';
import { UserStore } from './user/userStore';

interface ICounterProps {
    userStore: UserStore;
}

interface ICounterState {
    currentCount: number;
}

@inject('userStore')
@observer
export class Counter extends React.Component<RouteComponentProps<{}> & ICounterProps, ICounterState> {
    @observable public count: number;

    constructor(props: RouteComponentProps<{}> & ICounterProps) {
        super(props);
        this.state = { currentCount: 0 };
        this.count = 3;
    }

    public render() {
        return <div>
            <h1>Counter</h1>
            <h2>{this.props.userStore.userName}</h2>

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
