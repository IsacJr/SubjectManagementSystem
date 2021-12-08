import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class SubjectAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Subject';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllSubjects(): Observable<any> {
        return super.get(this.API_BASE);
    }

    public getOneSubject(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postSubject(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putSubject(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteSubject(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}