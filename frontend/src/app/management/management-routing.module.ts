import { Routes } from '@angular/router';
import { ChallengeComponent } from './challenge/challenge.component';

export const ManagementRoutes: Routes = [
    {
        path: '',
        redirectTo: 'challenge',
        pathMatch: 'full'
    },
    {
        path: 'challenge',
        component: ChallengeComponent
    }
];

