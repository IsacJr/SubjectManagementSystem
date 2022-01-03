import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { TeamFacade } from '../../team.facade';

@Component({
  selector: 'app-team',
  templateUrl: './team.component.html',
  styleUrls: ['./team.component.scss']
})
export class TeamComponent implements OnInit, OnDestroy {

  teamList: any[] = [];
  unsub$ = new Subject();

  constructor(
    private teamFacade: TeamFacade
  ) { }

  ngOnInit(): void {
    this.teamFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.teamList = response);
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
