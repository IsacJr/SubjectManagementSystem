import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ChallengeFacade } from '../../../challenge.facade';


@Component({
  selector: 'app-challenge',
  templateUrl: './challenge.component.html',
  styleUrls: ['./challenge.component.scss']
})
export class ChallengeComponent implements OnInit {

  challengeList: any[] = [];

  constructor(private challengeFacade: ChallengeFacade, private router: Router) { }

  ngOnInit(): void {
    this.challengeFacade.getAll().subscribe(response => this.challengeList = response);
  }

  handleVisualize() {
    this.router.navigate(['/challenge/view']);
    console.log('visualize event');
  }

  handleEdit() {
    console.log('edit event');
  }

  handleDelete() {
    console.log('delete event');
  }

}
