import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { UserAPI } from "./api/user.api";

@Injectable()
export class UserFacade {

    constructor(private challengeApi: UserAPI){ }

    public getAll(): Observable<any> {
        return this.challengeApi.getAllUsers();
    }

    public getOne(id: number): Observable<any> {
        return this.challengeApi.getOneUser(id);
    }

    public post(payload: any): Observable<any> {
        return this.challengeApi.postUser(payload);
    }

    public put(payload: any): Observable<any> {
        return this.challengeApi.putUser(payload);
    }

    public delete(id: number): Observable<any> {
        return this.challengeApi.deleteUser(id);
    }
}