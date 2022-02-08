import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { ChallengeFacade } from '../../../challenge.facade';


@Component({
  selector: 'app-challenge',
  templateUrl: './challenge.component.html',
  styleUrls: ['./challenge.component.scss']
})
export class ChallengeComponent implements OnInit, OnDestroy {

  challengeList: any[] = [];
  unsub$ = new Subject();

  constructor(
    private challengeFacade: ChallengeFacade,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.challengeFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.challengeList = response);
  }

  handleVisualize(evt: any) {
    const { id } = evt;
    this.router.navigate([`/challenge/view/${id}`]);
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/challenge/edit/${id}`]);
  }

  handleDelete() {
    console.log('delete event');
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
