import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';

import { AdminProfileComponent } from './admin-dashboard/admin-profile/admin-profile.component';
import { AdminJobsComponent } from './admin-dashboard/admin-jobs/admin-jobs.component';
import { AdminApplicantComponent } from './admin-dashboard/admin-applicant/admin-applicant.component';
import { AdminHrComponent } from './admin-dashboard/admin-hr/admin-hr.component';
import { HomeComponent } from './home/home.component';

import { ApplicantProfileComponent } from './applicant-dashboard/applicant-profile/applicant-profile.component';
import { ApplicantNewjobslistComponent } from './applicant-dashboard/applicant-newjobslist/applicant-newjobslist.component';
import { ApplicantJobstatusComponent } from './applicant-dashboard/applicant-jobstatus/applicant-jobstatus.component';

import { HumanresourceCreatejobComponent } from './humanresource-dashboard/humanresource-createjob/humanresource-createjob.component';
import { HumanresourceJoblistComponent } from './humanresource-dashboard/humanresource-joblist/humanresource-joblist.component';
import { HumanresourceApplicantlistComponent } from './humanresource-dashboard/humanresource-applicantlist/humanresource-applicantlist.component';
import { HumanresourceProfileComponent } from './humanresource-dashboard/humanresource-profile/humanresource-profile.component';

import { LoginComponent } from './authentication/login/login.component';
import { RegisterComponent } from './authentication/register/register.component';
import { ForgetpasswordComponent } from './authentication/forgetpassword/forgetpassword.component';
import { AuthenticationService } from './Services/authentication.component.service';
import { NotfoundComponent } from './notfound/notfound.component';
import { ApplicantEnrolljoblistComponent } from './applicant-dashboard/applicant-enrolljoblist/applicant-enrolljoblist.component';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import {
  HTTP_INTERCEPTORS,
  HttpClient,
  HttpClientModule,
} from '@angular/common/http';
import { AuthIntercept } from './Intercept/AuthIntercept.service';
import { AdminService } from './Services/admin.component.service';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,

    HomeComponent,

    ApplicantProfileComponent,
    ApplicantNewjobslistComponent,
    ApplicantJobstatusComponent,
    HumanresourceCreatejobComponent,
    HumanresourceJoblistComponent,
    HumanresourceApplicantlistComponent,
    HumanresourceProfileComponent,
    LoginComponent,
    RegisterComponent,
    ForgetpasswordComponent,
    NotfoundComponent,
    ApplicantEnrolljoblistComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    CommonModule,
    FormsModule,
  ],
  providers: [
    AuthenticationService,
    AdminService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthIntercept,
      multi: true,
    },
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
