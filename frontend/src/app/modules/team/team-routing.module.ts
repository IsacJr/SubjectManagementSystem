import { Routes } from '@angular/router';
import { TeamComponent } from './containers/team-list/team.component';
import { TeamNewComponent } from './containers/team-new/team-new.component';


export const TeamRoutes: Routes = [
    {
        path: '',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'team',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'list',
        component: TeamComponent
    },
    {
        path: 'new',
        component: TeamNewComponent
    }
];

