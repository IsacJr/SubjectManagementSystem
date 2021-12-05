import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseApi } from '../../core/services/base.api';

@Injectable()
export class EducationLevelAPI extends BaseApi<any> {

    private readonly API_BASE = super.baseUrl + '/EducationLevel';

    constructor(protected override http: HttpClient) {
        super(http);
    }

    public getAllEducationLevels(): Observable<any> {
        return super.get(this.API_BASE);
    }
}