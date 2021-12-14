import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { FieldAPI } from "./api/field.api";


@Injectable()
export class FieldFacade {

    constructor(private fieldApi: FieldAPI){ }

    public getAll(): Observable<any> {
        return this.fieldApi.getAllFields();
    }

    public getOne(id: number): Observable<any> {
        return this.fieldApi.getOneField(id);
    }

    public post(payload: any): Observable<any> {
        return this.fieldApi.postField(payload);
    }

    public put(payload: any): Observable<any> {
        return this.fieldApi.putField(payload);
    }

    public delete(id: number): Observable<any> {
        return this.fieldApi.deleteField(id);
    }
}
