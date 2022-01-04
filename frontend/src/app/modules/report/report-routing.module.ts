import { Routes } from '@angular/router';
import { ReportListComponent } from './containers/report-list/report-list.component';
import { ReportNewComponent } from './containers/report-new/report-new.component';



export const ReportRoutes: Routes = [
    {
        path: '',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'classroom',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'list',
        component: ReportListComponent
    },
    {
        path: 'new',
        component: ReportNewComponent
    }
];

