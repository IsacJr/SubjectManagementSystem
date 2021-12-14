import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { StateAPI } from "../api/state.api";

@Injectable()
export class StateFacade {

    constructor(private stateApi: StateAPI){ }

    public getAll(): Observable<any> {
        return this.stateApi.getAllStates();
    }
}