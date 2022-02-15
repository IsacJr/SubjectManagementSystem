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
import { CardRegularComponent } from './components/card-regular/card-regular.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    CardActionComponent,
    FilterComponent,
    DeleteDialogComponent,
    PaginationComponent,
    CardRegularComponent
  ],
  imports: [
    CommonModule,
    FontAwesomeModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule
  ],
  exports: [
    HeaderComponent,
    FooterComponent,
    CardActionComponent,
    FilterComponent,
    DeleteDialogComponent,
    PaginationComponent,
    CardRegularComponent
  ]
})
export class SharedModule { }
