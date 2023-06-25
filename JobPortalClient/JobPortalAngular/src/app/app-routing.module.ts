import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './authentication/login/login.component';
import { ForgetpasswordComponent } from './authentication/forgetpassword/forgetpassword.component';
import { RegisterComponent } from './authentication/register/register.component';
import { NotfoundComponent } from './notfound/notfound.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'forgetpassword', component: ForgetpasswordComponent },
  { path: 'register', component: RegisterComponent },
  {
    path: 'applicant',
    loadChildren: () =>
      import('./applicant-dashboard/applicant-module').then(
        (m) => m.ApplicantModule
      ),
  },
  {
    path: 'admin',
    loadChildren: () =>
      import('./admin-dashboard/admin-module').then((m) => m.AdminModule),
  },
  {
    path: 'hr',
    redirectTo: '/humanresource',
  },
  {
    path: 'humanresource',
    loadChildren: () =>
      import('./humanresource-dashboard/hr.module').then((m) => m.HrModule),
  },
  { path: '', component: HomeComponent },
  { path: '**', component: NotfoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
