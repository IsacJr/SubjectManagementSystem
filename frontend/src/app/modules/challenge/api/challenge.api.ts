import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class ChallengeAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/User';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllChallenges(): Observable<any> {
        return super.get(this.API_BASE);
    }

    public getOneChallenge(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postChallenge(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putChallenge(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteChallenge(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}