import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { SubjectFacade } from '../subject.facade';

@Component({
  selector: 'app-subject-list',
  templateUrl: './subject-list.component.html',
  styleUrls: ['./subject-list.component.scss']
})
export class SubjectListComponent implements OnInit, OnDestroy {

  subjectList: any[] = [];
  unsub$ = new Subject();
  
  constructor(
    private subjectFacade: SubjectFacade
  ) { }

  ngOnInit(): void {
    this.subjectFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.subjectList = response);
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
