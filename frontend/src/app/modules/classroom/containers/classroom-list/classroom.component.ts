import { Component, OnDestroy, OnInit } from '@angular/core';
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
    private classroomFacade: ClassroomFacade
  ) { }

  ngOnInit(): void {
    this.classroomFacade.getAll().subscribe(response => this.classroomList = response);
  }
  
  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
