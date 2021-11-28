import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UserListComponent } from './user-list/user-list.component';
import { UserNewComponent } from './user-new/user-new.component';
import { UserRoutes } from './user-routing.module';

@NgModule({
  declarations: [
    UserListComponent,
    UserNewComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(UserRoutes)
  ]
})
export class UserModule { }
