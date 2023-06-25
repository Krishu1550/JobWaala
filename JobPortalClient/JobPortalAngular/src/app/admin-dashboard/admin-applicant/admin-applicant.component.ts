import { Component, OnInit } from '@angular/core';
import { Applicant } from 'src/app/Interface/Applicant';
import { AdminService } from 'src/app/Services/admin.component.service';

@Component({
  selector: 'app-admin-applicant',
  templateUrl: './admin-applicant.component.html',
  styleUrls: ['./admin-applicant.component.css'],
})
export class AdminApplicantComponent implements OnInit {
  applicants?: Applicant[];

  constructor(private service: AdminService) {}
  ngOnInit(): void {
    this.service.getApplicant().subscribe({
      next: (data) => {
        this.applicants = data as Applicant[];
      },
      error: (error) => {
        console.log(error);
      },
      complete: () => {},
    });
  }
}
