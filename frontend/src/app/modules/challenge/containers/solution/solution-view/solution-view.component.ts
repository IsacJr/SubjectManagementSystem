import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { faPlus } from '@fortawesome/free-solid-svg-icons';
import { AuthService } from 'src/app/core/services/auth.service';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { SolutionFacade } from '../../../solution.facade';
import { StageFacade } from '../../../stage.facade';

@Component({
  selector: 'app-solution-view',
  templateUrl: './solution-view.component.html',
  styleUrls: ['./solution-view.component.scss']
})
export class SolutionViewComponent implements OnInit, OnDestroy {

  solution = {} as any;
  stageList = [] as any[];
  private currentId = 0;

  stageForm: FormGroup;
  
  private subscriptions = new SubscriptionsContainer();

  faPlus = faPlus;
  
  constructor(
    private formBuilder: FormBuilder,
    private solutionFacade: SolutionFacade,
    private stageFacade: StageFacade,
    private authService: AuthService,
    private router: Router,
    private activateRoute: ActivatedRoute
  ) {
    this.stageForm = this.formBuilder.group({
      description: '',
      link: ''
    });
    this.loadInfo();
  }

  ngOnInit(): void {
  }

  private loadInfo(){
    this.subscriptions.add = this.activateRoute.params.subscribe(params => {
      this.currentId = +params['id'];
      this.subscriptions.add = this.solutionFacade.getOne(this.currentId).subscribe(response => {
        this.solution = response;
        this.stageList = response.stages
      });
    })
  }

  get isCreatedButtonDisabled() {
    const { type } = this.authService.getUserInfo();
    if(type === 0)
      return false;
    return true;
  }

  get isDescriptionFieldDisabled() {
    const { type } = this.authService.getUserInfo();
    if(type === 0)
      return false;
    return true;
  }

  get isSolutionFieldDisabled() {
    const { type } = this.authService.getUserInfo();
    if(type === 2)
      return false;
    return true;
  }

  createStage(){
    const { description } = this.stageForm.value;
    const stagePayload = { description, idSolution: this.currentId, link: '' };
    this.stageFacade.post(stagePayload).subscribe(response => console.log(response));
  }

  updateStage(){

  }

  ngOnDestroy(): void {
    this.subscriptions.dispose();
  }

}
