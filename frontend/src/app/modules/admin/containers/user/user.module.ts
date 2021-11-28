import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { UserListComponent } from './user-list/user-list.component';
import { UserNewComponent } from './user-new/user-new.component';

@NgModule({
  declarations: [
    UserListComponent,
    UserNewComponent
  ],
  imports: [
    CommonModule
  ]
})
export class UserModule { }
