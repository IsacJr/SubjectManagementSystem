import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { StatusAPI } from "../api/status.api";

@Injectable()
export class StatusFacade {

    constructor(private statusApi: StatusAPI){ }

    public getAll(): Observable<any> {
        return this.statusApi.getAllStatus();
    }
}