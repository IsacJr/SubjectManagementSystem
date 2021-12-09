import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SubjectRoutes } from './subject-routing.module';
import { SubjectListComponent } from './subject-list/subject-list.component';
import { SubjectNewComponent } from './subject-new/subject-new.component';
import { SubjectAPI } from './api/subject.api';
import { SubjectFacade } from './subject.facade';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [
    SubjectListComponent,
    SubjectNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule.forChild(SubjectRoutes)
  ],
  providers: [
    SubjectAPI,
    SubjectFacade
  ]
})
export class SubjectModule { }
