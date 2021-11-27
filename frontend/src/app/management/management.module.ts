import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChallengeComponent } from './containers/challenge/challenge.component';
import { InstitutionComponent } from './containers/institution/institution.component';
import { ClassroomComponent } from './containers/classroom/classroom.component';
import { TeamComponent } from './containers/team/team.component';



@NgModule({
  declarations: [
    ChallengeComponent,
    InstitutionComponent,
    ClassroomComponent,
    TeamComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ManagementModule { }
