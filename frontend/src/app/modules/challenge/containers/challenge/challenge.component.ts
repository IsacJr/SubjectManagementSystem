import { Component, OnInit } from '@angular/core';
import { ChallengeFacade } from '../../challenge.facade';

@Component({
  selector: 'app-challenge',
  templateUrl: './challenge.component.html',
  styleUrls: ['./challenge.component.scss']
})
export class ChallengeComponent implements OnInit {

  challengeList: any;

  constructor(private challengeFacade: ChallengeFacade) { }

  ngOnInit(): void {
    this.challengeFacade.getAll().subscribe(challenges => {
      this.challengeList = challenges;
    });
  }

}
