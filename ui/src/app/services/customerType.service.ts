import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { BaseService } from "./base.service";
import { Urls } from "../shared/urls";
import { ICustomerModel } from '../models/customer.model';
import { ICustomerTypeModel } from '../models/customerType.model';

@Injectable({
  providedIn: "root",
})
export class CustomerTypeService extends BaseService<ICustomerTypeModel> {
  constructor(protected httpClient: HttpClient) {
    super(httpClient, Urls.customerTypes);
  }
}
