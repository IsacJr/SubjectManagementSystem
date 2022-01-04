import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './core/guards/auth.guard';
import { LoginGuard } from './core/guards/login.guard';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  {
    path: 'challenge',
    loadChildren: () => import('./modules/challenge/challenge.module').then(m => m.ChallengeModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'classroom',
    loadChildren: () => import('./modules/classroom/classroom.module').then(m => m.ClassroomModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'team',
    loadChildren: () => import('./modules/team/team.module').then(m => m.TeamModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'profile',
    loadChildren: () => import('./modules/profile/profile.module').then(m => m.ProfileModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'report',
    loadChildren: () => import('./modules/report/report.module').then(m => m.ReportModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'admin',
    loadChildren: () => import('./modules/admin/admin.module').then(m => m.AdminModule),
    canActivate: [AuthGuard]
  },
  {
    path: 'login',
    loadChildren: () => import('./core/authentication/login/login.module').then(m => m.LoginModule),
    canActivate: [LoginGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
