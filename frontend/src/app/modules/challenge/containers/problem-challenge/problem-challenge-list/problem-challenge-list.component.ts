import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-problem-challenge-list',
  templateUrl: './problem-challenge-list.component.html',
  styleUrls: ['./problem-challenge-list.component.scss']
})
export class ProblemChallengeListComponent implements OnInit {

  problemChallengeList: any[] = [];

  constructor() {
    this.problemChallengeList = this.mockProblemChallenge;
  }

  ngOnInit(): void {
  }

  mockProblemChallenge = [{
    challenge: {name: 'detecção de corrupção'},
    team: {members: [{name: 'silvio'}, {name: 'adolfo'}]}
  }];

}
