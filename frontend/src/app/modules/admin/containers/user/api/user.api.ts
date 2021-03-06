import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from "src/app/core/services/base.api";

@Injectable()
export class UserAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/User';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllUsers(params?: any): Observable<any> {
        return super.get(this.API_BASE, params);
    }

    public getOneUser(id: number): Observable<any> {
        return super.getOne(this.API_BASE, id);
    }

    public postUser(payload: any): Observable<any> {
        return super.post(this.API_BASE, payload);
    }

    public putUser(payload: any): Observable<any> {
        return super.put(this.API_BASE, payload);
    }

    public deleteUser(id: number): Observable<any> {
        return super.delete(this.API_BASE, id);
    }

    public getAllUserTypes(): Observable<any> {
        const url = this.API_BASE + '/GetAllUserType';
        return super.get(url);
    }

    public getUserByEmail(payload: any): Observable<any> {
        const customUrl = this.API_BASE + '/GetByEmail';
        return super.post(customUrl, payload);
    }

}