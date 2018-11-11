import { Component, OnInit, Input } from '@angular/core';
import { Project } from '../shared/models/project';
import { ManagerService } from '../shared/services/manager.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-project-template',
  templateUrl: './project-template.component.html',
  styleUrls: ['./project-template.component.css']
})
export class ProjectTemplateComponent implements OnInit {

  @Input()
  project: Project;

  constructor(public managerService:ManagerService,public router:Router) { }

  ngOnInit() {

  }

  addWorkerToProject()
  {
 
     this.managerService.workerToProject=this.project;
     this.router.navigate(["/manager/addWorkerToProject"])
  }

  showWorker()
  {
    this.managerService.project=this.project;
    this.router.navigate(["/manager/userInProject"])
  }


}
