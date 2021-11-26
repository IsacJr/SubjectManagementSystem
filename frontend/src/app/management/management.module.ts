import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChallengeComponent } from './challenge/challenge.component';
import { InstitutionComponent } from './institution/institution.component';
import { ClassroomComponent } from './classroom/classroom.component';
import { TeamComponent } from './team/team.component';



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
