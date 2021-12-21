import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ProfileRoutes } from './profile-routing.module';
import { ProfileComponent } from './containers/profile/profile.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserAPI } from '../admin/containers/user/api/user.api';
import { UserFacade } from '../admin/containers/user/user.facade';
import { InstitutionAPI } from '../admin/containers/institution/api/institution.api';
import { InstitutionFacade } from '../admin/containers/institution/institution.facade';
import { StateAPI } from 'src/app/shared/api/state.api';
import { StateFacade } from 'src/app/shared/services/state.facade';


@NgModule({
  declarations: [
    ProfileComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(ProfileRoutes)
  ],
  providers: [
    UserAPI,
    UserFacade,
    InstitutionAPI,
    InstitutionFacade,
    StateAPI,
    StateFacade
  ]
})
export class ProfileModule { }
