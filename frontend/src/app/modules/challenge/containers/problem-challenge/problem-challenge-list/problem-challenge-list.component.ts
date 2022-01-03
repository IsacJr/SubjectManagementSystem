import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-problem-challenge-list',
  templateUrl: './problem-challenge-list.component.html',
  styleUrls: ['./problem-challenge-list.component.scss']
})
export class ProblemChallengeListComponent implements OnInit, OnDestroy {

  problemChallengeList: any[] = [];

  unsub$ = new Subject();

  constructor() { }

  ngOnInit(): void {
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
