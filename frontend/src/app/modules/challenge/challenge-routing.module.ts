import { Routes } from '@angular/router';
import { ChallengeComponent } from './containers/challenge/challenge.component';
import { NewChallengeComponent } from './containers/new-challenge/new-challenge.component';

export const ChallengeRoutes: Routes = [
    {
        path: '',
        redirectTo: 'challenge/list',
        pathMatch: 'full'
    },
    {
        path: 'challenge',
        redirectTo: 'challenge/list',
        pathMatch: 'full'
    },
    {
        path: 'challenge/list',
        component: ChallengeComponent
    },
    {
        path: 'challenge/new',
        component: NewChallengeComponent
    }
];

