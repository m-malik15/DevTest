import { environment } from "src/environments/environment";

export class Urls {
  private static apiBaseUrl: string = environment.apiBaseUrl;
  static jobs = `${Urls.apiBaseUrl}/job`;
  static engineers = `${Urls.apiBaseUrl}/engineer`;
  static customers = `${Urls.apiBaseUrl}/customer`;
  static customerTypes = `${Urls.apiBaseUrl}/customerType`;
}
