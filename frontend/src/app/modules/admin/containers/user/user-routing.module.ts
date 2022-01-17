import { Routes } from '@angular/router';
import { UserListComponent } from './user-list/user-list.component';
import { UserNewComponent } from './user-new/user-new.component';


export const UserRoutes: Routes = [
    {
        path: '',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'list',
        component: UserListComponent
    },
    {
        path: 'new',
        component: UserNewComponent
    },
    {
        path: 'edit/:id',
        component: UserNewComponent
    }
];

