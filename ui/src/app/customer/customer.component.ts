import { Component, OnInit } from "@angular/core";
import { ICustomerTypeModel } from "../models/customerType.model";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { CustomerTypeService } from "../services/customerType.service";
import { ICustomerModel } from "../models/customer.model";
import { CustomerService } from "../services/customer.service";

@Component({
  selector: "app-customer",
  templateUrl: "./customer.component.html",
  styleUrls: ["./customer.component.scss"],
})
export class CustomerComponent implements OnInit {
  customerTypes: ICustomerTypeModel[];
  addCustomerForm: FormGroup;
  customer: ICustomerModel;
  customers: ICustomerModel[];
  submitted = false;
  constructor(
    private fb: FormBuilder,
    private customerService: CustomerService,
    private customerTypeService: CustomerTypeService
  ) {}

  ngOnInit() {
    this.loadForm();
    this.getCustomerTypes();
    this.getCustomers();
  }

  getCustomerTypes() {
    this.customerTypeService.getAll().subscribe((resp) => {
      this.customerTypes = resp;
    });
  }

  getCustomers() {
    this.customerService.getAll().subscribe((resp) => {
      this.customers = resp;
    });
  }

  loadForm() {
    this.addCustomerForm = this.fb.group({
      name: ["", [Validators.required, Validators.minLength(5)]],
      type: [null, Validators.required],
    });
  }

  setCustomer() {
    this.customer = {
      customerId: 0,
      customerTypeId: this.addCustomerForm.get("type").value,
      name: this.addCustomerForm.get("name").value,
      customerType: null,
    };
  }

  setFormValues(customerModel: ICustomerModel) {
    this.addCustomerForm.patchValue({
      name: customerModel.name,
      type: customerModel.customerTypeId,
    });
  }

  // convenience getter for easy access to form fields
  get type() {
    return this.addCustomerForm.get("type");
  }

  get name() {
    return this.addCustomerForm.get("name");
  }

  save() {
    this.submitted = true;

    if (this.addCustomerForm.invalid) {
      return;
    }

    this.setCustomer();

    this.customerService.add(this.customer).subscribe((data) => {
      this.setFormValues(data);
      this.getCustomers();
    });
  }
}
