import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from '../../core/services/base.api';

@Injectable()
export class StatusAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Status';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllStatus(): Observable<any> {
        return super.get(this.API_BASE);
    }
}