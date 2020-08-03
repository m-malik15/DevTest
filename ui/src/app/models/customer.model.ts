import { ICustomerTypeModel } from './customerType.model';

export interface ICustomerModel {
    customerId: number;
    name: string;
    customerTypeId: number;
    customerType: ICustomerTypeModel;
}
