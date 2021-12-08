import { Routes } from '@angular/router';
import { ProfileComponent } from './profile/profile.component';


export const ProfileRoutes: Routes = [
    {
        path: '',
        redirectTo: 'my-profile',
        pathMatch: 'full'
    },
    {
        path: 'profile',
        redirectTo: 'my-profile',
        pathMatch: 'full'
    },
    {
        path: 'my-profile',
        component: ProfileComponent
    }
];

