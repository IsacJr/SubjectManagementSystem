import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InstitutionListComponent } from './institution-list/institution-list.component';
import { InstitutionNewComponent } from './institution-new/institution-new.component';
import { RouterModule } from '@angular/router';
import { InstitutionRoutes } from './institution-routing.module';
import { InstitutionFacade } from './institution.facade';
import { InstitutionAPI } from './api/institution.api';
import { SharedModule } from 'src/app/shared/shared.module';



@NgModule({
  declarations: [
    InstitutionListComponent,
    InstitutionNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    RouterModule.forChild(InstitutionRoutes)
  ],
  providers: [
    InstitutionAPI,
    InstitutionFacade
  ]
})
export class InstitutionModule { }
