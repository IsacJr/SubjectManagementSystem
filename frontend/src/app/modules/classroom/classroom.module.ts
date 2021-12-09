import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ClassroomAPI } from './api/classroom.api';
import { ClassroomRoutes } from './classroom-routing.module';
import { ClassroomFacade } from './classroom.facade';
import { ClassroomComponent } from './containers/classroom-list/classroom.component';


@NgModule({
  declarations: [
    ClassroomComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(ClassroomRoutes)
  ],
  providers: [
    ClassroomAPI,
    ClassroomFacade
  ]
})
export class ClassroomModule { }
