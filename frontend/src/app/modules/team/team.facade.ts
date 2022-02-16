import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { TeamAPI } from "./api/team.api";

@Injectable()
export class TeamFacade {

    constructor(private teamApi: TeamAPI){ }

    public getAll(params?: any): Observable<any> {
        return this.teamApi.getAllTeams(params);
    }

    public getOne(id: number): Observable<any> {
        return this.teamApi.getOneTeam(id);
    }

    public post(payload: any): Observable<any> {
        return this.teamApi.postTeam(payload);
    }

    public put(payload: any): Observable<any> {
        return this.teamApi.putTeam(payload);
    }

    public delete(id: number): Observable<any> {
        return this.teamApi.deleteTeam(id);
    }
}