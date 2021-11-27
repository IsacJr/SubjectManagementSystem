import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserComponent } from './containers/user/user.component';
import { SubjectComponent } from './containers/subject/subject.component';

@NgModule({
  declarations: [
    UserComponent,
    SubjectComponent
  ],
  imports: [
    CommonModule
  ]
})
export class AdminModule { }
