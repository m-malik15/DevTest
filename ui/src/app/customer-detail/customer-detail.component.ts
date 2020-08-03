import { Component, OnInit } from "@angular/core";
import { JobModel } from "../models/job.model";
import { ActivatedRoute } from "@angular/router";
import { JobService } from "../services/job.service";
import { CustomerService } from "../services/customer.service";
import { ICustomerModel } from "../models/customer.model";

@Component({
  selector: "app-customer-detail",
  templateUrl: "./customer-detail.component.html",
  styleUrls: ["./customer-detail.component.scss"],
})
export class CustomerDetailComponent implements OnInit {
  private customerId: number;

  public customer: ICustomerModel;

  constructor(
    private route: ActivatedRoute,
    private customerService: CustomerService
  ) {
    this.customerId = route.snapshot.params.id;
  }

  ngOnInit() {
    this.customerService
      .getSingle(this.customerId)
      .subscribe((customer) => (this.customer = customer));
  }
}
