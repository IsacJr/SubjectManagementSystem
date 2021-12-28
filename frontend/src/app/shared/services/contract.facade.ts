import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ContractAPI } from "../api/contract.api";

@Injectable()
export class ContractFacade {

    constructor(private contractApi: ContractAPI){ }

    public proposePartnership(payload: any): Observable<any> {
        return this.contractApi.postProposePartnership(payload);
    }
}