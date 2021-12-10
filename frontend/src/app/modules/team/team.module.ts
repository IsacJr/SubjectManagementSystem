import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { TeamAPI } from './api/team.api';
import { TeamComponent } from './containers/team-list/team.component';
import { TeamRoutes } from './team-routing.module';
import { TeamFacade } from './team.facade';
import { TeamNewComponent } from './containers/team-new/team-new.component';


@NgModule({
  declarations: [
    TeamComponent,
    TeamNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule.forChild(TeamRoutes)
  ],
  providers: [
    TeamAPI,
    TeamFacade
  ]
})
export class TeamModule { }
