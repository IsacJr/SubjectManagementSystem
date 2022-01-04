import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class SolutionAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/Solution';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllSolutions(): Observable<any> {
        return super.get(this.API_BASE);
    }

    public getOneSolution(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postSolution(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putSolution(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteSolution(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

}