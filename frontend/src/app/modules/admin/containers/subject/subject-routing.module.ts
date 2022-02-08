import { Routes } from '@angular/router';
import { SubjectListComponent } from './subject-list/subject-list.component';
import { SubjectNewComponent } from './subject-new/subject-new.component';

export const SubjectRoutes: Routes = [
    
    {
        path: '',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'list',
        component: SubjectListComponent
    },
    {
        path: 'new',
        component: SubjectNewComponent
    },
    {
        path: 'edit/:id',
        component: SubjectNewComponent
    }
];

