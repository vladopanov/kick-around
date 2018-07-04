import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './features/Layout';
import { Home } from './features/Home';
import { FetchData } from './features/FetchData';
import { Counter } from './features/Counter';

export const routes = <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/counter' component={Counter} />
    <Route path='/fetchdata' component={FetchData} />
</Layout>;
