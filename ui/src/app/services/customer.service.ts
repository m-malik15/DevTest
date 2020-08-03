import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BaseService } from "./base.service";
import { Urls } from "../shared/urls";
import { ICustomerModel } from '../models/customer.model';

@Injectable({
  providedIn: "root",
})
export class CustomerService extends BaseService<ICustomerModel> {
  constructor(protected httpClient: HttpClient) {
    super(httpClient, Urls.customers);
  }
}
