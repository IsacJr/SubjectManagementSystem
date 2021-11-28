import { Routes } from '@angular/router';
import { UserListComponent } from './user-list/user-list.component';
import { UserNewComponent } from './user-new/user-new.component';


export const UserRoutes: Routes = [
    {
        path: '',
        redirectTo: 'admin/user',
        pathMatch: 'full'
    },
    {
        path: 'admin/user',
        component: UserListComponent
    },
    {
        path: 'admin/new',
        component: UserNewComponent
    }
];

