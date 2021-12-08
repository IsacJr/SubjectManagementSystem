import { Routes } from '@angular/router';

export const AdminRoutes: Routes = [
    
    {
        path: 'admin',
        redirectTo: 'admin/user',
        pathMatch: 'full'
    },
    {
        path: 'admin/user',
        loadChildren: () => import('./containers/user/user.module').then(m => m.UserModule)
    },
    {
        path: 'admin/institution',
        loadChildren: () => import('./containers/institution/institution.module').then(m => m.InstitutionModule)
    },
    {
        path: 'admin/subject',
        loadChildren: () => import('./containers/subject/subject.module').then(m => m.SubjectModule)
    }
];

