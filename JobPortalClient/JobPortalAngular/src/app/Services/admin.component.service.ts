import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class AdminService {
  apiurl = 'https://localhost:7128/api/';

  constructor(private http: HttpClient) {}

  getHumanResource() {
    return this.http.get(this.apiurl + 'HumanResource');
  }
  getApplicant() {
    return this.http.get(this.apiurl + 'Applicant');
  }
  getJob() {
    return this.http.get(this.apiurl + 'Jobs/getalljob');
  }
}
