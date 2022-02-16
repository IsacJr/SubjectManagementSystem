import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class TeamAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Team';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllTeams(params?: any): Observable<any> {
        return super.get(this.API_BASE, params);
    }

    public getOneTeam(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postTeam(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putTeam(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteTeam(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}