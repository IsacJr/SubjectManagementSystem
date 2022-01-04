import { Component, OnInit } from '@angular/core';
import { faPlus } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-solution-view',
  templateUrl: './solution-view.component.html',
  styleUrls: ['./solution-view.component.scss']
})
export class SolutionViewComponent implements OnInit {

  solution = {} as any;
  stageList = [] as any[];

  faPlus = faPlus;
  
  constructor() {
    this.stageList = [{}, {}]
  }

  ngOnInit(): void {
  }

}
