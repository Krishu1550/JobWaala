import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HumanresourceDashboardComponent } from './humanresource-dashboard.component';
import { HRRoutingModule } from './hr-routing.module';

@NgModule({
  declarations: [HumanresourceDashboardComponent],
  imports: [CommonModule, HRRoutingModule],
})
export class HrModule {}
