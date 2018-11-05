import { Component, OnInit } from '@angular/core';
import { ExcelService } from '../shared/services/excel.service';

@Component({
  selector: 'app-create-report',
  templateUrl: './create-report.component.html',
  styleUrls: ['./create-report.component.css']
})
export class CreateReportComponent  {

constructor(public excelServise:ExcelService) {

}
  name = 'Angular 6';
  data: any = [{
    eid: 'e101',
    ename: 'ravi',
    esal: 1000
  },
  {
    eid: 'e102',
    ename: 'ram',
    esal: 2000
  },
  {
    eid: 'e103',
    ename: 'rajesh',
    esal: 3000
  }];
 
  exportAsXLSX():void {
    this.excelServise.exportAsExcelFile(this.data, 'sample');
  }
}



