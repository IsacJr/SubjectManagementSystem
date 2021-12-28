import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class ContractAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Contract';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public postProposePartnership(payload: any): Observable<any> {
        const customUrl = this.API_BASE + '/ProposePartnership'
        return super.post(customUrl, payload);
    }
}