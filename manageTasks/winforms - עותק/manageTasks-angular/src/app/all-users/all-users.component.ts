import { Component, OnInit } from '@angular/core';
import { User } from '../shared/models/user';
import { UserService } from '../shared/services/user.service';
import { ManagerService } from '../shared/services/manager.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-all-users',
  templateUrl: './all-users.component.html',
  styleUrls: ['./all-users.component.css']
})
export class AllUsersComponent implements OnInit {

  users: User[]=[];

  constructor(public userService:UserService,public managerService:ManagerService,public router:Router) {

    this.getAllUsers();
   }

  ngOnInit() {
 
  }

  addUser()
  {
    this.router.navigate(['/manager/addUser']);
  }

  getAllUsers()
  {
    this.userService.getAllUsers().subscribe(res=>{
      console.log(res);
      this.users=res;
    });
  }

  deleteUser(id:number)
  {
    let indexUser=this.users.findIndex(p=>p.userId==id)
    this.managerService.deleteUser(id).subscribe(res=>{
      this.users.splice( indexUser,1);
    },err=>{})
  }

}
