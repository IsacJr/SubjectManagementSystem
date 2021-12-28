import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class ProblemProblemAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/ProblemChallenge';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllProblems(): Observable<any> {
        return super.get(this.API_BASE);
    }

    public getOneProblem(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postProblem(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putProblem(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteProblem(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}