import { Routes } from '@angular/router';
import { ClassroomComponent } from './classroom-list/classroom.component';

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
    }
];

