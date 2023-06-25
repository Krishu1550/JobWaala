import { Component, OnInit } from '@angular/core';
import { HumanResourse } from 'src/app/Interface/HumanResourse';
import { AdminService } from 'src/app/Services/admin.component.service';

@Component({
  selector: 'app-admin-hr',
  templateUrl: './admin-hr.component.html',
  styleUrls: ['./admin-hr.component.css'],
})
export class AdminHrComponent implements OnInit {
  humanResources?: HumanResourse[];
  constructor(private service: AdminService) {}
  ngOnInit(): void {
    this.service.getHumanResource().subscribe({
      next: (data) => {
        console.log(data);
        this.humanResources = data as HumanResourse[];
      },
      error: (error) => {
        console.log(error);
      },
    });
  }
}
