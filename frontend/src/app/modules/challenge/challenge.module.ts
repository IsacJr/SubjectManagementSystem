import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChallengeComponent } from './containers/challenge/challenge.component';
import { InstitutionComponent } from './containers/institution/institution.component';
import { ClassroomComponent } from './containers/classroom/classroom.component';
import { TeamComponent } from './containers/team/team.component';
import { NewChallengeComponent } from './containers/new-challenge/new-challenge.component';
import { ChallengeAPI } from './api/challenge.api';
import { ChallengeFacade } from './challenge.facade';



@NgModule({
  declarations: [
    ChallengeComponent,
    InstitutionComponent,
    ClassroomComponent,
    TeamComponent,
    NewChallengeComponent
  ],
  imports: [
    CommonModule
  ],
  providers: [
    ChallengeAPI,
    ChallengeFacade
  ]
})
export class ChallengeModule { }
