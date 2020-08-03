import {  HttpClient } from "@angular/common/http";
import { map } from "rxjs/operators";
import { Observable } from "rxjs";

export abstract class BaseService<T> {
  constructor(protected httpClient: HttpClient, protected actionUrl: string) {}

  getAll(): Observable<T[]> {
    return this.httpClient.get(this.actionUrl).pipe(
      map((resp) => {
        return resp as T[];
      })
    );
  }
  getSingle(id: number): Observable<T> {
    return this.httpClient.get<T>(`${this.actionUrl}/${id}`).pipe(
      map((resp) => {
        return resp as T;
      })
    );
  }

  add(T): Observable<T> {
    return this.httpClient.post<T>(this.actionUrl, T).pipe(
      map((resp) => {
        return resp as T;
      })
    );
  }

  update(id: number, T): Observable<T> {
    return this.httpClient.put<T>(`${this.actionUrl}/${id}`, T).pipe(
      map((resp) => {
        return resp as T;
      })
    );
  }
}
