import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { CardActionComponent } from './components/card-action/card-action.component';
import { RouterModule } from '@angular/router';
import { FilterComponent } from './components/filter/filter.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { DeleteDialogComponent } from './components/dialogs/delete-dialog/delete-dialog.component';
import { PaginationComponent } from './components/pagination/pagination.component';



@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    CardActionComponent,
    FilterComponent,
    DeleteDialogComponent,
    PaginationComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule,
    RouterModule
  ],
  exports: [
    HeaderComponent,
    FooterComponent,
    CardActionComponent,
    FilterComponent,
    DeleteDialogComponent,
    PaginationComponent
  ]
})
export class SharedModule { }
