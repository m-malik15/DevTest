import { IEngineerModel } from "./engineer.model";
import { ICustomerModel } from "./customer.model";

export interface JobModel {
  jobId: number;
  engineerId: number;
  customerId: number;
  when: Date;
  engineer: IEngineerModel;
  customer: ICustomerModel;
}
