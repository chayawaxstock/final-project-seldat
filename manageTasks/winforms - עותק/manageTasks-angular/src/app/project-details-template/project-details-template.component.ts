import { Component, OnInit,Input } from '@angular/core';
import { Project } from '../shared/models/project';

@Component({
  selector: 'app-project-details-template',
  templateUrl: './project-details-template.component.html',
  styleUrls: ['./project-details-template.component.css']
})
export class ProjectDetailsTemplateComponent implements OnInit {

  @Input()
  project: Project;

  constructor() { }

  ngOnInit() {
  }

}
