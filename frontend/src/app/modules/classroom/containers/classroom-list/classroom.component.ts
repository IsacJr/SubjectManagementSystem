import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';
import { ClassroomFacade } from '../../classroom.facade';

@Component({
  selector: 'app-classroom',
  templateUrl: './classroom.component.html',
  styleUrls: ['./classroom.component.scss']
})
export class ClassroomComponent implements OnInit, OnDestroy {

  classroomList: any[] = [];

  unsub$ = new Subject();

  constructor(
    private classroomFacade: ClassroomFacade,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.classroomFacade.getAll().subscribe(response => this.classroomList = response);
  }

  handleVisualize() {
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/classroom/edit/${id}`]);
  }

  handleDelete() {
    console.log('delete event');
  }
  
  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
