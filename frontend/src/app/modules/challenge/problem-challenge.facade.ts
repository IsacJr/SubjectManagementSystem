import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ProblemChallengeAPI } from "./api/problem-challenge.api";

@Injectable()
export class ProblemChallengeFacade {

    constructor(private problemChallengeApi: ProblemChallengeAPI){ }

    public getAll(params?: any): Observable<any> {
        return this.problemChallengeApi.getAllProblems(params);
    }

    public getOne(id: number): Observable<any> {
        return this.problemChallengeApi.getOneProblem(id);
    }

    public post(payload: any): Observable<any> {
        return this.problemChallengeApi.postProblem(payload);
    }

    public put(payload: any): Observable<any> {
        return this.problemChallengeApi.putProblem(payload);
    }

    public delete(id: number): Observable<any> {
        return this.problemChallengeApi.deleteProblem(id);
    }
}