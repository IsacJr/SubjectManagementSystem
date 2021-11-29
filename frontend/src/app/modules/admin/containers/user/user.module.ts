import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { CardUserComponent } from '../../components/user/card-user/card-user.component';
import { UserAPI } from './api/user.api';
import { UserFacade } from './challenge.facade';
import { UserListComponent } from './user-list/user-list.component';
import { UserNewComponent } from './user-new/user-new.component';
import { UserRoutes } from './user-routing.module';

@NgModule({
  declarations: [
    UserListComponent,
    UserNewComponent,
    CardUserComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule.forChild(UserRoutes)
  ],
  providers: [
    UserAPI,
    UserFacade
  ]
})
export class UserModule { }
