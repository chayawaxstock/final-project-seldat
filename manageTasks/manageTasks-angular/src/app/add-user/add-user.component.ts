import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { User } from '../shared/models/user';
import { DepartmentUser } from '../shared/models/departmentUser';
import { UserService } from '../shared/services/user.service';
import { ManagerService } from '../shared/services/manager.service';
import { createValidatorText, createValidatorNumber, DepartmentEnum } from '../shared/validators/user.validation';
import sha256 =require( 'async-sha256');

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.css']
})
export class AddUserComponent  {

  formGroup: FormGroup;
  obj: typeof Object = Object;
  user: User;
  departments: DepartmentUser[]=[];
  userByDepartment:User[]=[];

  constructor(public userService:UserService,public managerService:ManagerService) {

  userService.getAllDepartments().subscribe(departments=>{ this.departments=departments;
    console.log(this.departments);
  });

  let  emailPattern = /^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$/; 
  let formGroupConfig = {
    userName: new FormControl("", createValidatorText("userName", 2, 15)),
    password: new FormControl("", createValidatorText("password", 5, 10)),
    email:new FormControl("",createValidatorText("email", 5, 30,emailPattern)),
    numHoursWork:new FormControl("", createValidatorNumber("numHoursWork", 4, 9)),
    departmentId: new FormControl("",[Validators.required]),
    managerId:new FormControl()
  };
  this.formGroup = new FormGroup(formGroupConfig);
  }

  addUser() {
    if (this.formGroup.invalid) {
      return;
    }
    else {
      this.user = this.formGroup.value;
      console.log(this.user);
      sha256(this.user.password).then(p=>{this.user.password=p;
      this.managerService.addUser(this.user).subscribe(res=>{
        alert("add user");
      },err=>{alert("error not add user")});

      });

    }
  }

  chooseDepartment()
  {
    
   let value=this.formGroup.controls['departmentId'].value;
    if(value==DepartmentEnum.TEAMLEADER)
    {
      this.managerService.getUsersByDepartment("manager").subscribe(users=>{
        console.log(users);
        this.userByDepartment=users;
      });
    }
    else if(value!=DepartmentEnum.MANAGER){
      this.managerService.getUsersByDepartment("teamLeader").subscribe(users=>{
        console.log(users);
        this.userByDepartment=users;
      });
    }
    else {
      this.userByDepartment=[];
    }
  }
}
