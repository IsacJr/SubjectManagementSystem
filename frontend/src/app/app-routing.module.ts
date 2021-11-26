import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ManagementRoutes } from './management/management-routing.module';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'challenge',
    pathMatch: 'full'
  },
  ...ManagementRoutes
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
