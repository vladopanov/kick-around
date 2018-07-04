import { UserStore } from './features';

export class App {
    public services: {};
    public stores: {};

    constructor() {
        this.registerServices();
        this.registerStores();
    }

    private registerServices() {

    }

    private registerStores() {
        this.stores = {
            userStore: new UserStore(this)
        };
    }
}