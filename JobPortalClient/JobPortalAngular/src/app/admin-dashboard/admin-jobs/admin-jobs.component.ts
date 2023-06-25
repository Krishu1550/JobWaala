import { Component, OnInit } from '@angular/core';
import { Job } from 'src/app/Interface/Job';
import { AdminService } from 'src/app/Services/admin.component.service';

@Component({
  selector: 'app-admin-jobs',
  templateUrl: './admin-jobs.component.html',
  styleUrls: ['./admin-jobs.component.css'],
})
export class AdminJobsComponent implements OnInit {
  jobs?: Job[];
  constructor(private service: AdminService) {}
  ngOnInit(): void {
    this.service.getJob().subscribe({
      next: (data) => {
        this.jobs = data as Job[];
      },
      error: (error) => {
        console.log(error);
      },
      complete: () => {},
    });
  }
}
