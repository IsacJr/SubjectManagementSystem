import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ChallengeAPI } from "./api/challenge.api";

@Injectable()
export class ChallengeFacade {

    constructor(private challengeApi: ChallengeAPI){ }

    public getAll(): Observable<any> {
        return this.challengeApi.getAllChallenges();
    }

    public getOne(id: number): Observable<any> {
        return this.challengeApi.getOneChallenge(id);
    }

    public post(payload: any): Observable<any> {
        return this.challengeApi.postChallenge(payload);
    }

    public put(payload: any): Observable<any> {
        return this.challengeApi.putChallenge(payload);
    }

    public delete(id: number): Observable<any> {
        return this.challengeApi.deleteChallenge(id);
    }
}