import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { TeamComponent } from './team-list/team.component';
import { TeamRoutes } from './team-routing.module';


@NgModule({
  declarations: [
    TeamComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(TeamRoutes)
  ],
  providers: [
    
  ]
})
export class TeamModule { }
