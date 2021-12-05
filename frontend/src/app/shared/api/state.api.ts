import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class StateAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/State';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllStates(): Observable<any> {
        return super.get(this.API_BASE);
    }
}