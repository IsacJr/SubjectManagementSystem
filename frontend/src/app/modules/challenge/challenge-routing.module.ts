import { Routes } from '@angular/router';
import { ChallengeComponent } from './containers/challenge/challenge-list/challenge.component';
import { NewChallengeComponent } from './containers/challenge/new-challenge/new-challenge.component';
import { ViewChallengeComponent } from './containers/challenge/view-challenge/view-challenge.component';
import { SolutionViewComponent } from './containers/solution/solution-view/solution-view.component';

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
    },
    {
        path: 'edit/:id',
        component: NewChallengeComponent
    },
    {
        path: 'solution/:id',
        component: SolutionViewComponent
    }
];

