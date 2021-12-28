import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { UserAPI } from "./api/user.api";

@Injectable()
export class UserFacade {

    constructor(private userApi: UserAPI){ }

    public getAll(params?: any): Observable<any> {
        return this.userApi.getAllUsers(params);
    }

    public getOne(id: number): Observable<any> {
        return this.userApi.getOneUser(id);
    }

    public post(payload: any): Observable<any> {
        return this.userApi.postUser(payload);
    }

    public put(payload: any): Observable<any> {
        return this.userApi.putUser(payload);
    }

    public delete(id: number): Observable<any> {
        return this.userApi.deleteUser(id);
    }

    public getAllUserTypes(): Observable<any> {
        return this.userApi.getAllUserTypes();
    }

    public getUserByEmail(payload: any): Observable<any> {
        return this.userApi.getUserByEmail(payload);
    }
}