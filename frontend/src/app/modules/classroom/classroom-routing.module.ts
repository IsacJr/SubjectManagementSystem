import { Routes } from '@angular/router';
import { ClassroomComponent } from './containers/classroom-list/classroom.component';
import { ClassroomNewComponent } from './containers/classroom-new/classroom-new.component';


export const ClassroomRoutes: Routes = [
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
        component: ClassroomComponent
    },
    {
        path: 'new',
        component: ClassroomNewComponent
    }
];

