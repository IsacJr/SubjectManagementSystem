import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ReportAPI } from "./api/classroom.api";


@Injectable()
export class ReportFacade {

    constructor(private reportApi: ReportAPI){ }

    public getAll(params?: any): Observable<any> {
        return this.reportApi.getAllReports(params);
    }

    public getOne(id: number): Observable<any> {
        return this.reportApi.getOneReport(id);
    }

    public post(payload: any): Observable<any> {
        return this.reportApi.postReport(payload);
    }

    public put(payload: any): Observable<any> {
        return this.reportApi.putReport(payload);
    }

    public delete(id: number): Observable<any> {
        return this.reportApi.deleteReport(id);
    }
}