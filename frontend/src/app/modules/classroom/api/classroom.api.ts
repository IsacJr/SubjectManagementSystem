import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class ClassroomAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Classroom';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllClassrooms(params?: any): Observable<any> {
        return super.get(this.API_BASE, params);
    }

    public getOneClassroom(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postClassroom(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putClassroom(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteClassroom(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}