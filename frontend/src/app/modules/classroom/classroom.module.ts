import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { SharedModule } from 'src/app/shared/shared.module';
import { FieldAPI } from '../admin/containers/field/api/field.api';
import { FieldFacade } from '../admin/containers/field/field.facade';
import { SubjectAPI } from '../admin/containers/subject/api/subject.api';
import { SubjectFacade } from '../admin/containers/subject/subject.facade';
import { UserAPI } from '../admin/containers/user/api/user.api';
import { UserFacade } from '../admin/containers/user/user.facade';
import { ClassroomAPI } from './api/classroom.api';
import { ClassroomRoutes } from './classroom-routing.module';
import { ClassroomFacade } from './classroom.facade';
import { ClassroomComponent } from './containers/classroom-list/classroom.component';
import { ClassroomNewComponent } from './containers/classroom-new/classroom-new.component';


@NgModule({
  declarations: [
    ClassroomComponent,
    ClassroomNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(ClassroomRoutes)
  ],
  providers: [
    ClassroomAPI,
    ClassroomFacade,
    UserAPI,
    UserFacade,
    SubjectAPI,
    SubjectFacade,
    FieldAPI,
    FieldFacade
  ]
})
export class ClassroomModule { }
