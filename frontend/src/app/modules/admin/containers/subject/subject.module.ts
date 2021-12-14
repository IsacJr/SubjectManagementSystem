import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SubjectRoutes } from './subject-routing.module';
import { SubjectListComponent } from './subject-list/subject-list.component';
import { SubjectNewComponent } from './subject-new/subject-new.component';
import { SubjectAPI } from './api/subject.api';
import { SubjectFacade } from './subject.facade';
import { SharedModule } from 'src/app/shared/shared.module';
import { EducationLevelAPI } from 'src/app/shared/api/education-level.api';
import { EducationLevelFacade } from 'src/app/shared/services/education-level.facade';
import { FieldAPI } from '../field/api/field.api';
import { FieldFacade } from '../field/field.facade';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    SubjectListComponent,
    SubjectNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(SubjectRoutes)
  ],
  providers: [
    SubjectAPI,
    SubjectFacade,
    EducationLevelAPI,
    EducationLevelFacade,
    FieldAPI,
    FieldFacade
  ]
})
export class SubjectModule { }
