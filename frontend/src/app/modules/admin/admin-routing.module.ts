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
    }
];

