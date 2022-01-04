import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { SolutionAPI } from "./api/solution.api";


@Injectable()
export class SolutionFacade {

    constructor(private solutionApi: SolutionAPI){ }

    public getAll(): Observable<any> {
        return this.solutionApi.getAllSolutions();
    }

    public getOne(id: number): Observable<any> {
        return this.solutionApi.getOneSolution(id);
    }

    public post(payload: any): Observable<any> {
        return this.solutionApi.postSolution(payload);
    }

    public put(payload: any): Observable<any> {
        return this.solutionApi.putSolution(payload);
    }

    public delete(id: number): Observable<any> {
        return this.solutionApi.deleteSolution(id);
    }
}