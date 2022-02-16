import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class ReportAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Report';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllReports(params?: any): Observable<any> {
        return super.get(this.API_BASE, params);
    }

    public getOneReport(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postReport(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putReport(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteReport(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}