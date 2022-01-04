import { Routes } from '@angular/router';
import { AuthGuard } from 'src/app/core/guards/auth.guard';

export const AdminRoutes: Routes = [
    
    {
        path: 'admin',
        redirectTo: 'admin/user',
        pathMatch: 'full'
    },
    {
        path: 'admin/user',
        loadChildren: () => import('./containers/user/user.module').then(m => m.UserModule),
        canActivate: [AuthGuard]
    },
    {
        path: 'admin/institution',
        loadChildren: () => import('./containers/institution/institution.module').then(m => m.InstitutionModule),
        canActivate: [AuthGuard]
    },
    {
        path: 'admin/subject',
        loadChildren: () => import('./containers/subject/subject.module').then(m => m.SubjectModule),
        canActivate: [AuthGuard]
    }
];

