import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ClassroomComponent } from './classroom-list/classroom.component';
import { ClassroomRoutes } from './classroom-routing.module';


@NgModule({
  declarations: [
    ClassroomComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(ClassroomRoutes)
  ],
  providers: [
    
  ]
})
export class ClassroomModule { }
