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
import { NgSelectModule } from '@ng-select/ng-select';
import { InstitutionFacade } from '../admin/containers/institution/institution.facade';
import { InstitutionAPI } from '../admin/containers/institution/api/institution.api';
import { FieldAPI } from '../admin/containers/field/api/field.api';
import { FieldFacade } from '../admin/containers/field/field.facade';


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
    NgSelectModule,
    RouterModule.forChild(TeamRoutes)
  ],
  providers: [
    TeamAPI,
    TeamFacade,
    UserAPI,
    UserFacade,
    InstitutionAPI,
    InstitutionFacade,
    FieldAPI,
    FieldFacade
  ]
})
export class TeamModule { }
