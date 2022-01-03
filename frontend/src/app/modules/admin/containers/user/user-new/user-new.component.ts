import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { StateFacade } from 'src/app/shared/services/state.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { UserFacade } from '../user.facade';

@Component({
  selector: 'app-user-new',
  templateUrl: './user-new.component.html',
  styleUrls: ['./user-new.component.scss']
})
export class UserNewComponent implements OnInit, OnDestroy {

  readonly PAGE_TITLE_LABEL = "Novo Usuário";
  stateList = [] as any[];
  userTypeList = [] as any[];

  userForm: FormGroup;

  subscriptions = new SubscriptionsContainer();
  
  constructor(private formBuilder: FormBuilder, private userFacade: UserFacade, private stateFacade: StateFacade) {
    this.userForm = this.formBuilder.group({
      name: '',
      type: null,
      email: '',
      birthday: '',
      city: '',
      state: null
    });

    this.subscriptions.add = stateFacade.getAll().subscribe(response => this.stateList = response);
    this.subscriptions.add = userFacade.getAllUserTypes().subscribe(response => this.userTypeList = response);
  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.userForm.value;
    this.subscriptions.add = this.userFacade.post(payload).subscribe(response => console.log(response));
  }

  changeState(event: any) {
    this.userForm.get('state')?.setValue(+event.target.value);
  }

  changeType(event: any) {
    this.userForm.get('type')?.setValue(+event.target.value);
  }

  ngOnDestroy(): void {
    this.subscriptions.dispose();
  }

}
