import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from 'src/app/shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { ReportListComponent } from './containers/report-list/report-list.component';
import { ReportNewComponent } from './containers/report-new/report-new.component';
import { ReportRoutes } from './report-routing.module';
import { ReportAPI } from './api/classroom.api';
import { ReportFacade } from './report.facade';



@NgModule({
  declarations: [
    ReportListComponent,
    ReportNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(ReportRoutes)
  ],
  providers: [
    ReportAPI,
    ReportFacade
  ]
})
export class ReportModule { }
