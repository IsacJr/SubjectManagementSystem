import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { InstitutionAPI } from "./api/institution.api";

@Injectable()
export class InstitutionFacade {

    constructor(private institutionApi: InstitutionAPI){ }

    public getAll(): Observable<any> {
        return this.institutionApi.getAllInstitutions();
    }

    public getOne(id: number): Observable<any> {
        return this.institutionApi.getOneInstitution(id);
    }

    public post(payload: any): Observable<any> {
        return this.institutionApi.postInstitution(payload);
    }

    public put(payload: any): Observable<any> {
        return this.institutionApi.putInstitution(payload);
    }

    public delete(id: number): Observable<any> {
        return this.institutionApi.deleteInstitution(id);
    }
}