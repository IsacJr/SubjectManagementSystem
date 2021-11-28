import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http"
import { map, Observable } from "rxjs";

@Injectable({
    providedIn: HttpClient
})

export abstract class BaseApi<T> {
    constructor(protected http: HttpClient) { }

    public get baseUrl(): string {
        return 'https://localhost:5001';
    }

    protected get(url: string): Observable<any> {
        return this.http.get<T>(url).pipe(map((response: T) => response ));
    }

    protected getOne(url: string, id: number): Observable<any> {
        const urlFull = `${url}/${id}`;
        return this.http.get<T>(url).pipe(map((response: T) => response));
    }

    protected post(url: string, payload: T): Observable<any> {
        return this.http.post<T>(url, payload);
    }

    protected put(url: string, payload: T): Observable<any> {
        return this.http.put<T>(url, payload);
    }

    protected delete(url: string, id: number): Observable<any> {
        const urlFull = `${url}/${id}`
        return this.http.delete<T>(urlFull);
    }

}