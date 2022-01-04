import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class StageAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Stage';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllStages(): Observable<any> {
        return super.get(this.API_BASE);
    }

    public getOneStage(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postStage(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putStage(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteStage(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}