import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { EducationLevelAPI } from "../api/education-level.api";

@Injectable()
export class EducationLevelFacade {

    constructor(private educationLevelApi: EducationLevelAPI){ }

    public getAll(): Observable<any> {
        return this.educationLevelApi.getAllEducationLevels();
    }
}