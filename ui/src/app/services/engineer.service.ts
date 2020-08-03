import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BaseService } from "./base.service";
import { IEngineerModel } from "../models/engineer.model";
import { Urls } from "../shared/urls";

@Injectable({
  providedIn: "root",
})
export class EngineerService extends BaseService<IEngineerModel> {
  constructor(protected httpClient: HttpClient) {
    super(httpClient, Urls.engineers);
  }
}
