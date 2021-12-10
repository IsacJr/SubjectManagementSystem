import { Component, OnInit } from '@angular/core';
import { TeamFacade } from '../../team.facade';

@Component({
  selector: 'app-team',
  templateUrl: './team.component.html',
  styleUrls: ['./team.component.scss']
})
export class TeamComponent implements OnInit {

  teamList: any[] = [];

  constructor(
    private teamFacade: TeamFacade
  ) { }

  ngOnInit(): void {
    this.teamFacade.getAll().subscribe(response => this.teamList = response);
  }

}
