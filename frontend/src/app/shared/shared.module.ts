import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { CardActionComponent } from './components/card-action/card-action.component';
import { RouterModule } from '@angular/router';
import { FilterComponent } from './components/filter/filter.component';



@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    CardActionComponent,
    FilterComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [
    HeaderComponent,
    FooterComponent,
    CardActionComponent,
    FilterComponent
  ]
})
export class SharedModule { }
