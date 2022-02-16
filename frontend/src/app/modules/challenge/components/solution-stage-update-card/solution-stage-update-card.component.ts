import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AuthService } from 'src/app/core/services/auth.service';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { StageFacade } from '../../stage.facade';

@Component({
  selector: 'app-solution-stage-update-card',
  templateUrl: './solution-stage-update-card.component.html',
  styleUrls: ['./solution-stage-update-card.component.scss']
})
export class SolutionStageUpdateCardComponent implements OnInit, OnDestroy {

  @Input() stage: any;

  stageForm: FormGroup;

  private subscription = new SubscriptionsContainer();

  constructor(
    private formBuilder: FormBuilder,
    private stageFacade: StageFacade,
    private authService: AuthService
  )
  {
    this.stageForm = this.formBuilder.group({
      description: '',
      link: ''
    });
  }

  ngOnInit(): void {
    this.loadForm();
  }

  private loadForm() {
    this.stageForm?.get('description')?.setValue(this.stage?.description);
    this.stageForm?.get('link')?.setValue(this.stage?.link);
  }

  get isStageDelivered(): boolean {
    return this.stage?.link !== "" ? true : false;
  }

  deliveryStage() {
    const { description, link } = this.stageForm.value;
    const { id, idSolution } = this.stage;
    const stagePayload = { id, description, link, idSolution };

    this.subscription.add = this.stageFacade.put(stagePayload).subscribe(response => console.log(response));
  }

  get isCreatedButtonDisabled() {
    const { type } = this.authService.getUserInfo();
    if(type === 2)
      return false;
    return true;
  }

  get isSolutionFieldDisabled() {
    const { type } = this.authService.getUserInfo();
    if(type === 2)
      return false;
    return true;
  }

  ngOnDestroy(): void {
    this.subscription.dispose();
  }

}
