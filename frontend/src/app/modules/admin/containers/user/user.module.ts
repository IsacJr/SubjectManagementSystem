import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { CardUserComponent } from '../../components/user/card-user/card-user.component';
import { FilterUserComponent } from '../../components/user/filter-user/filter-user.component';
import { UserAPI } from './api/user.api';
import { UserFacade } from './user.facade';
import { UserListComponent } from './user-list/user-list.component';
import { UserNewComponent } from './user-new/user-new.component';
import { UserRoutes } from './user-routing.module';
import { InstitutionAPI } from '../institution/api/institution.api';
import { InstitutionFacade } from '../institution/institution.facade';
import { EducationLevelFacade } from 'src/app/shared/services/education-level.facade';
import { EducationLevelAPI } from 'src/app/shared/api/education-level.api';
import { StateAPI } from 'src/app/shared/api/state.api';
import { StateFacade } from 'src/app/shared/services/state.facade';

@NgModule({
  declarations: [
    UserListComponent,
    UserNewComponent,
    CardUserComponent,
    FilterUserComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    SharedModule,
    RouterModule.forChild(UserRoutes)
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
export class UserModule { }
