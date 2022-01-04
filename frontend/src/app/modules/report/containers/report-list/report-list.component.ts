import { Component, OnInit } from '@angular/core';
import { take } from 'rxjs';
import { ReportFacade } from '../../report.facade';

@Component({
  selector: 'app-report-list',
  templateUrl: './report-list.component.html',
  styleUrls: ['./report-list.component.scss']
})
export class ReportListComponent implements OnInit {

  reportList: any[] = [];
  
  constructor(
    private reportFacade: ReportFacade
  )
  {
    reportFacade.getAll().pipe(take(1)).subscribe(response => this.reportList = response);
  }

  ngOnInit(): void {
  }

}
