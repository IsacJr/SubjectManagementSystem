import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AdminRoutes } from './admin-routing.module';
import { SubjectComponent } from './containers/subject/subject.component';

@NgModule({
  declarations: [
    SubjectComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(AdminRoutes)
  ]
})
export class AdminModule { }
