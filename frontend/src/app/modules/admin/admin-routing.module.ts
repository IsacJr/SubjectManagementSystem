import { Routes } from '@angular/router';
import { UserRoutes } from './containers/user/user-routing.module';

export const AdminRoutes: Routes = [
    {
        path: 'admin',
        redirectTo: 'admin/user',
        pathMatch: 'full'
    },
    ...UserRoutes
];

