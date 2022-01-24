import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { faPlus } from '@fortawesome/free-solid-svg-icons';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { SolutionFacade } from '../../../solution.facade';
import { StageFacade } from '../../../stage.facade';

@Component({
  selector: 'app-solution-view',
  templateUrl: './solution-view.component.html',
  styleUrls: ['./solution-view.component.scss']
})
export class SolutionViewComponent implements OnInit {

  solution = {} as any;
  stageList = [] as any[];
  currentId = 0;
  
  subscriptions = new SubscriptionsContainer();

  faPlus = faPlus;
  
  constructor(
    private solutionFacade: SolutionFacade,
    private stageFacade: StageFacade,
    private router: Router,
    private activateRoute: ActivatedRoute
  ) {
    this.subscriptions.add = this.activateRoute.params.subscribe(params => {
      this.currentId = +params['id'];
      this.subscriptions.add = this.solutionFacade.getOne(this.currentId).subscribe(response => this.solution = response);
      this.subscriptions.add = this.stageFacade.getAll().subscribe(response => this.stageList = response);
    })
  }

  ngOnInit(): void {
  }

}
