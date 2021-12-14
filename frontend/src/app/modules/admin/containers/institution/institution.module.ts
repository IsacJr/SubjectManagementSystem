import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InstitutionListComponent } from './institution-list/institution-list.component';
import { InstitutionNewComponent } from './institution-new/institution-new.component';
import { RouterModule } from '@angular/router';
import { InstitutionRoutes } from './institution-routing.module';
import { InstitutionFacade } from './institution.facade';
import { InstitutionAPI } from './api/institution.api';
import { SharedModule } from 'src/app/shared/shared.module';
import { StateAPI } from 'src/app/shared/api/state.api';
import { StateFacade } from 'src/app/shared/services/state.facade';
import { FieldAPI } from '../field/api/field.api';
import { FieldFacade } from '../field/field.facade';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    InstitutionListComponent,
    InstitutionNewComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(InstitutionRoutes)
  ],
  providers: [
    InstitutionAPI,
    InstitutionFacade,
    StateAPI,
    StateFacade,
    FieldAPI,
    FieldFacade
  ]
})
export class InstitutionModule { }
