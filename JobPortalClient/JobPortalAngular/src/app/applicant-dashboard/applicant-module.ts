import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ApplicantRoutingModule } from './applicant-routing.module';
import { ApplicantDashboardComponent } from './applicant-dashboard.component';

@NgModule({
  declarations: [ApplicantDashboardComponent],
  imports: [CommonModule, ApplicantRoutingModule],
})
export class ApplicantModule {}
