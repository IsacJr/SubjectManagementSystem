import { Subscription } from "rxjs";

export class SubscriptionsContainer {
    private subscriptionList = [] as Subscription[];

    public set add(s: Subscription) {
        this.subscriptionList.push(s);
    }

    public dispose() {
        this.subscriptionList.map(s => s.unsubscribe());
    }
}