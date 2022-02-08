import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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
    private subjectFacade: SubjectFacade,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.subjectFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.subjectList = response);
  }

  handleVisualize() {
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/admin/subject/edit/${id}`]);
  }

  handleDelete() {
    console.log('delete event');
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
