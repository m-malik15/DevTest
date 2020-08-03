import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { JobComponent } from "./job/job.component";
import { HomeComponent } from "./home/home.component";
import { JobDetailComponent } from "./job-detail/job-detail.component";
import { CustomerComponent } from "./customer/customer.component";
import { MatInputModule } from "@angular/material/input";
import { MatSelectModule } from "@angular/material/select";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { NgSelectModule } from "@ng-select/ng-select";
import { MatButtonModule } from "@angular/material/button";
import { CustomerDetailComponent } from "./customer-detail/customer-detail.component";
import { RouterModule } from "@angular/router";
import { MatFormFieldModule } from '@angular/material/form-field';

@NgModule({
  declarations: [
    AppComponent,
    JobComponent,
    HomeComponent,
    JobDetailComponent,
    CustomerComponent,
    CustomerDetailComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatInputModule,
    MatSelectModule,
    MatButtonModule,
    MatFormFieldModule
  ],

  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
