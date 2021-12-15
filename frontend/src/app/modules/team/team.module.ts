import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { TeamAPI } from './api/team.api';
import { TeamComponent } from './containers/team-list/team.component';
import { TeamRoutes } from './team-routing.module';
import { TeamFacade } from './team.facade';
import { TeamNewComponent } from './containers/team-new/team-new.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserAPI } from '../admin/containers/user/api/user.api';
import { UserFacade } from '../admin/containers/user/user.facade';


@NgModule({
  declarations: [
    TeamComponent,
    TeamNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(TeamRoutes)
  ],
  providers: [
    TeamAPI,
    TeamFacade,
    UserAPI,
    UserFacade
  ]
})
export class TeamModule { }
