import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Project } from '../models/project';
import { Global } from './global';
import { ProjectWorker } from '../models/projectWorker';

@Injectable()
export class TeamleaderService {

  constructor(public httpClient:HttpClient) { }

  getProjectTeamLeader(teamLeaderId:number):Observable<Project[]>
  {
    return this.httpClient.get<Project[]>(Global.baseURI+"getProjectsManager/"+teamLeaderId);
  }
  getUserBelongProject(projectId:number):Observable<ProjectWorker[]>
  {
    return this.httpClient.get<ProjectWorker[]>(Global.baseURI+"Users/getUserBelongProject/"+projectId);
  }
}
