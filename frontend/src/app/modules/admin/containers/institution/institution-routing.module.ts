import { Routes } from '@angular/router';
import { InstitutionListComponent } from './institution-list/institution-list.component';
import { InstitutionNewComponent } from './institution-new/institution-new.component';

export const InstitutionRoutes: Routes = [
    
    {
        path: '',
        redirectTo: 'list',
        pathMatch: 'full'
    },
    {
        path: 'list',
        component: InstitutionListComponent
    },
    {
        path: 'new',
        component: InstitutionNewComponent
    },
    {
        path: 'edit/:id',
        component: InstitutionNewComponent
    }
];

