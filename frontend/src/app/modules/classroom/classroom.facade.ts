import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ClassroomAPI } from "./api/classroom.api";

@Injectable()
export class ClassroomFacade {

    constructor(private classroomApi: ClassroomAPI){ }

    public getAll(params?: any): Observable<any> {
        return this.classroomApi.getAllClassrooms(params);
    }

    public getOne(id: number): Observable<any> {
        return this.classroomApi.getOneClassroom(id);
    }

    public post(payload: any): Observable<any> {
        return this.classroomApi.postClassroom(payload);
    }

    public put(payload: any): Observable<any> {
        return this.classroomApi.putClassroom(payload);
    }

    public delete(id: number): Observable<any> {
        return this.classroomApi.deleteClassroom(id);
    }
}