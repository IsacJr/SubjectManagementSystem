import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserComponent } from './user/user.component';
import { SubjectComponent } from './subject/subject.component';



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
