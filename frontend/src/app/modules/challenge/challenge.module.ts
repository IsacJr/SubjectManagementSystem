import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { StatusAPI } from 'src/app/shared/api/status.api';
import { StatusFacade } from 'src/app/shared/services/status.facade';
import { SharedModule } from 'src/app/shared/shared.module';
import { FieldAPI } from '../admin/containers/field/api/field.api';
import { FieldFacade } from '../admin/containers/field/field.facade';
import { InstitutionAPI } from '../admin/containers/institution/api/institution.api';
import { InstitutionFacade } from '../admin/containers/institution/institution.facade';
import { UserAPI } from '../admin/containers/user/api/user.api';
import { UserFacade } from '../admin/containers/user/user.facade';
import { ClassroomAPI } from '../classroom/api/classroom.api';
import { ClassroomFacade } from '../classroom/classroom.facade';
import { TeamAPI } from '../team/api/team.api';
import { TeamFacade } from '../team/team.facade';
import { ChallengeAPI } from './api/challenge.api';
import { ChallengeRoutes } from './challenge-routing.module';
import { ChallengeFacade } from './challenge.facade';
import { ChallengeComponent } from './containers/challenge/challenge-list/challenge.component';
import { NewChallengeComponent } from './containers/challenge/new-challenge/new-challenge.component';
import { ViewChallengeComponent } from './containers/challenge/view-challenge/view-challenge.component';


@NgModule({
  declarations: [
    ChallengeComponent,
    NewChallengeComponent,
    ViewChallengeComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule,
    RouterModule.forChild(ChallengeRoutes)
  ],
  providers: [
    ChallengeAPI,
    ChallengeFacade,
    InstitutionAPI,
    InstitutionFacade,
    FieldAPI,
    FieldFacade,
    UserAPI,
    UserFacade,
    ClassroomAPI,
    ClassroomFacade,
    StatusAPI,
    StatusFacade,
    TeamAPI,
    TeamFacade
  ]
})
export class ChallengeModule { }
