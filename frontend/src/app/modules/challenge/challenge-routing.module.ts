import { Routes } from '@angular/router';
import { ChallengeComponent } from './containers/challenge/challenge.component';
import { NewChallengeComponent } from './containers/new-challenge/new-challenge.component';

export const ChallengeRoutes: Routes = [
    {
        path: '',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'challenge',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'list',
        component: ChallengeComponent
    },
    {
        path: 'new',
        component: NewChallengeComponent
    }
];

