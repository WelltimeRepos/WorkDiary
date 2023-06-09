import { Component, OnInit } from '@angular/core';
import { JobsService } from '../../services/jobs.service';
import { Job } from '../../models/Job';
import { Provider } from '../../models/Provider';
import { Router } from '@angular/router';

@Component({
  selector: 'app-Jobs',
  templateUrl: './Jobs.component.html',
  styleUrls: ['./Jobs.component.css']
})
export class JobsComponent implements OnInit {

  public jobs:any = [];
  providers: { [key: number]: Provider[] } = {};

  constructor(private jobsService:JobsService,
              private router: Router) { }

  ngOnInit() {
    const currentUser = this.getObjectFromLocalStorage('User');
    this.getJobs(currentUser.USER_ID);
  }

  JobDetails(Job_Id: number) {
    this.jobsService.JobId = Job_Id;
    this.router.navigate(['/buyers/jobDetails']);
  }

  getJobs(USER_ID: number) {
    this.jobsService.getJobs(USER_ID).subscribe(
      (response: Job[]) => {
        if (response != null) {
          this.jobs = response;

          response.forEach((job: Job) => {
            this.getProvByJobId(job.JOB_ID, USER_ID);
          });

        }
        else {
          console.log("No Jobs Found");
        }
      },
      error => {
        console.log(error);
      });
  }

  getProvByJobId(jobId: number, buyerId: number) {
    this.jobsService.getProvidersByJob(jobId, buyerId).subscribe(
      (response:any[]) => {
        if (response != null) {
          this.providers[jobId] = response;
        }
      },
      (error) => {
        console.log(error);
      }
    );
  }

  getObjectFromLocalStorage(key: string): any {
    const storedValue = localStorage.getItem(key);
    return storedValue ? JSON.parse(storedValue) : null;
  }


  editItem(item: any): void {
    item.editing = true;
  }

  cancelEdit(item: any): void {
    item.editing = false;
    // Implement the cancel edit functionality here
    console.log('Cancel edit item:', item);
  }

  saveJob(item: any): void {
    item.editing = false;
  }

}
