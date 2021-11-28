import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminRoutes } from './modules/admin/admin-routing.module';
import { ChallengeRoutes } from './modules/challenge/challenge-routing.module';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'challenge',
    pathMatch: 'full'
  },
  {
    path: 'admin',
    redirectTo: 'admin'
  },
  {
    path: 'challenge',
    loadChildren: () => import('./modules/challenge/challenge.module').then(m => m.ChallengeModule)
  },
  ...AdminRoutes
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
