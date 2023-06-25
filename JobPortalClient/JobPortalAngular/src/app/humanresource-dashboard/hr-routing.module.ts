import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HumanresourceDashboardComponent } from './humanresource-dashboard.component';
import { HumanresourceProfileComponent } from './humanresource-profile/humanresource-profile.component';
import { HumanresourceApplicantlistComponent } from './humanresource-applicantlist/humanresource-applicantlist.component';
import { HumanresourceCreatejobComponent } from './humanresource-createjob/humanresource-createjob.component';
import { HumanresourceJoblistComponent } from './humanresource-joblist/humanresource-joblist.component';
const routes: Routes = [
  {
    path: '',
    component: HumanresourceDashboardComponent,
    children: [
      { path: 'hrprofile', component: HumanresourceProfileComponent },
      { path: 'applicantlist', component: HumanresourceApplicantlistComponent },
      { path: 'createjob', component: HumanresourceCreatejobComponent },
      { path: 'hrjoblist', component: HumanresourceJoblistComponent },
    ],
  },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HRRoutingModule {}
