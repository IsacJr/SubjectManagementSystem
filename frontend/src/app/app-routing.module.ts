import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './core/guards/auth.guard';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  {
    path: 'challenge',
    loadChildren: () => import('./modules/challenge/challenge.module').then(m => m.ChallengeModule)
  },
  {
    path: 'classroom',
    loadChildren: () => import('./modules/classroom/classroom.module').then(m => m.ClassroomModule)
  },
  {
    path: 'team',
    loadChildren: () => import('./modules/team/team.module').then(m => m.TeamModule)
  },
  {
    path: 'profile',
    loadChildren: () => import('./modules/profile/profile.module').then(m => m.ProfileModule)
  },
  {
    path: 'admin',
    loadChildren: () => import('./modules/admin/admin.module').then(m => m.AdminModule)
  },
  {
    path: 'login',
    loadChildren: () => import('./core/authentication/login/login.module').then(m => m.LoginModule),
    canActivate: [AuthGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
