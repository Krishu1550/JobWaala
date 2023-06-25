import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin-dashboard.component';
import { AdminApplicantComponent } from './admin-applicant/admin-applicant.component';
import { AdminHrComponent } from './admin-hr/admin-hr.component';
import { AdminJobsComponent } from './admin-jobs/admin-jobs.component';
import { AdminProfileComponent } from './admin-profile/admin-profile.component';
const routes: Routes = [
  {
    path: '',
    component: AdminDashboardComponent,
    children: [
      { path: 'applicantlist', component: AdminApplicantComponent },
      { path: 'hrlist', component: AdminHrComponent },
      { path: 'joblist', component: AdminJobsComponent },
      {
        path: 'adminprofile',
        component: AdminProfileComponent,
      },
    ],
  },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminRoutingModule {}
