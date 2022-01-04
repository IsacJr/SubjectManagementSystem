import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { StageAPI } from "./api/stage.api";


@Injectable()
export class StageFacade {

    constructor(private stageApi: StageAPI){ }

    public getAll(): Observable<any> {
        return this.stageApi.getAllStages();
    }

    public getOne(id: number): Observable<any> {
        return this.stageApi.getOneStage(id);
    }

    public post(payload: any): Observable<any> {
        return this.stageApi.postStage(payload);
    }

    public put(payload: any): Observable<any> {
        return this.stageApi.putStage(payload);
    }

    public delete(id: number): Observable<any> {
        return this.stageApi.deleteStage(id);
    }
}