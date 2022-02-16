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
import { ChallengeAPI } from '../challenge/api/challenge.api';
import { ChallengeFacade } from '../challenge/challenge.facade';
import { UserAPI } from '../admin/containers/user/api/user.api';
import { UserFacade } from '../admin/containers/user/user.facade';
import { ProblemChallengeAPI } from '../challenge/api/problem-challenge.api';
import { ProblemChallengeFacade } from '../challenge/problem-challenge.facade';
import { InstitutionAPI } from '../admin/containers/institution/api/institution.api';
import { InstitutionFacade } from '../admin/containers/institution/institution.facade';
import { FieldAPI } from '../admin/containers/field/api/field.api';
import { FieldFacade } from '../admin/containers/field/field.facade';



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
    ReportFacade,
    ChallengeAPI,
    ChallengeFacade,
    UserAPI,
    UserFacade,
    ProblemChallengeAPI,
    ProblemChallengeFacade,
    InstitutionAPI,
    InstitutionFacade,
    FieldAPI,
    FieldFacade
  ]
})
export class ReportModule { }
