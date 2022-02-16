import { Component, OnDestroy, OnInit } from '@angular/core';
import { FieldFacade } from 'src/app/modules/admin/containers/field/field.facade';
import { InstitutionFacade } from 'src/app/modules/admin/containers/institution/institution.facade';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { ReportFacade } from '../../report.facade';

@Component({
  selector: 'app-report-list',
  templateUrl: './report-list.component.html',
  styleUrls: ['./report-list.component.scss']
})
export class ReportListComponent implements OnInit, OnDestroy {

  reportList: any[] = [];
  
  institutionList: any[] = [];
  fieldList: any[] = [];

  private subscriptions = new SubscriptionsContainer();
  private filter: FilterQueryParamsModel | null = null;
  
  constructor(
    private reportFacade: ReportFacade,
    private institutionFacade: InstitutionFacade,
    private fieldFacade: FieldFacade
  )
  {
    this.subscriptions.add = reportFacade.getAll().subscribe(response => this.reportList = response);
    
    this.subscriptions.add = institutionFacade.getAll().subscribe(response => this.institutionList = response);
    this.subscriptions.add = fieldFacade.getAll().subscribe(response => this.fieldList = response);
  }

  ngOnInit(): void {
  }

  handleFilterEmitted(evt: FilterQueryParamsModel | null) {
    this.filter = evt;
    this.doFilter();
  }

  private doFilter(){
    this.subscriptions.add = this.reportFacade.getAll(this.filter).subscribe(response => this.reportList = response);
  }

  ngOnDestroy(): void {
    this.subscriptions.dispose();
}

}
