import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class InstitutionAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Institution';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllInstitutions(): Observable<any> {
        return super.get(this.API_BASE);
    }

    public getOneInstitution(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postInstitution(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putInstitution(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteInstitution(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}