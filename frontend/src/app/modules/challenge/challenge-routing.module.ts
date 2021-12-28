import { Routes } from '@angular/router';
import { ChallengeComponent } from './containers/challenge/challenge-list/challenge.component';
import { NewChallengeComponent } from './containers/challenge/new-challenge/new-challenge.component';
import { ViewChallengeComponent } from './containers/challenge/view-challenge/view-challenge.component';

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
    },
    {
        path: 'view/:id',
        component: ViewChallengeComponent
    }
];

