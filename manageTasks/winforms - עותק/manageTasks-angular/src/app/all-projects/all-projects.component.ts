import { Component, OnInit } from '@angular/core';
import { Project } from '../shared/models/project';
import { ManagerService } from '../shared/services/manager.service';

@Component({
  selector: 'app-all-projects',
  templateUrl: './all-projects.component.html',
  styleUrls: ['./all-projects.component.css']
})
export class AllProjectsComponent implements OnInit {
 projects: Project[]=[];
  constructor(public managerService:ManagerService) { }
 
  ngOnInit() {
    this.getAllProjects();
    //get all project after add ,delete 
    this.managerService.subjectProject.subscribe(v=>{
    this.getAllProjects();
     })
  }

  getAllProjects()
  {
    this.managerService.getAllProjects().subscribe(res=>{
      console.log(res);
      this.projects=res;
    });
  }


}
