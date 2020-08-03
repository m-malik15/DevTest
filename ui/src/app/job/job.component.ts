import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { EngineerService } from "../services/engineer.service";
import { JobService } from "../services/job.service";
import { JobModel } from "../models/job.model";
import { IEngineerModel } from "../models/engineer.model";
import { ICustomerModel } from "../models/customer.model";
import { CustomerService } from "../services/customer.service";

@Component({
  selector: "app-job",
  templateUrl: "./job.component.html",
  styleUrls: ["./job.component.scss"],
})
export class JobComponent implements OnInit {
  public engineers: IEngineerModel[] = [];
  public jobs: JobModel[] = [];
  public customers: ICustomerModel[] = [];

  public newJob: JobModel = {
    jobId: 0,
    engineerId: null,
    customerId: null,
    when: null,
    engineer: null,
    customer: null,
  };

  constructor(
    private engineerService: EngineerService,
    private jobService: JobService,
    private customerService: CustomerService
  ) {}

  ngOnInit() {
    this.getJobs();
    this.getEngineers();
    this.getCustomers();
  }

  getJobs() {
    this.jobService.getAll().subscribe((jobs) => (this.jobs = jobs));
  }

  getEngineers() {
    this.engineerService
      .getAll()
      .subscribe((engineers) => (this.engineers = engineers));
  }

  getCustomers() {
    this.customerService
      .getAll()
      .subscribe((customsers) => (this.customers = customsers));
  }

  public createJob(form: NgForm): void {
    console.log(form);
    if (form.invalid) {
      alert("form is not valid");
    } else {
      this.jobService.add(this.newJob).subscribe(() => {
        this.getJobs();
      });
    }
  }
}
