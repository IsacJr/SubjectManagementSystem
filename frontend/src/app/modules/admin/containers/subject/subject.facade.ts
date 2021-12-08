import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { SubjectAPI } from "./api/subject.api";

@Injectable()
export class SubjectFacade {

    constructor(private subjectAPI: SubjectAPI){ }

    public getAll(): Observable<any> {
        return this.subjectAPI.getAllSubjects();
    }

    public getOne(id: number): Observable<any> {
        return this.subjectAPI.getOneSubject(id);
    }

    public post(payload: any): Observable<any> {
        return this.subjectAPI.postSubject(payload);
    }

    public put(payload: any): Observable<any> {
        return this.subjectAPI.putSubject(payload);
    }

    public delete(id: number): Observable<any> {
        return this.subjectAPI.deleteSubject(id);
    }
}