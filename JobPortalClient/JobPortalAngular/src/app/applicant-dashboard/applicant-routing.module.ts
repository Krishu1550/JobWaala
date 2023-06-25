import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ApplicantDashboardComponent } from './applicant-dashboard.component';
import { ApplicantNewjobslistComponent } from './applicant-newjobslist/applicant-newjobslist.component';
import { ApplicantJobstatusComponent } from './applicant-jobstatus/applicant-jobstatus.component';
import { ApplicantProfileComponent } from './applicant-profile/applicant-profile.component';
import { ApplicantEnrolljoblistComponent } from './applicant-enrolljoblist/applicant-enrolljoblist.component';
const routes: Routes = [
  {
    path: '',
    component: ApplicantDashboardComponent,
    children: [
      { path: 'jobstatus', component: ApplicantJobstatusComponent },
      { path: 'newjobs', component: ApplicantNewjobslistComponent },
      { path: 'userprofile', component: ApplicantProfileComponent },
      { path: 'userjoblist', component: ApplicantEnrolljoblistComponent },
    ],
  },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ApplicantRoutingModule {}
