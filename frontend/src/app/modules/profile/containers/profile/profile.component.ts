import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { StateFacade } from 'src/app/shared/services/state.facade';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {

  stateList = [] as any[];
  userTypeList = [] as any[];

  userForm: FormGroup;
  
  constructor(private formBuilder: FormBuilder, private userFacade: UserFacade, private stateFacade: StateFacade) {
    this.userForm = this.formBuilder.group({
      name: '',
      type: null,
      email: '',
      birthday: '',
      city: '',
      state: null,
      password: ''
    });

    stateFacade.getAll().subscribe(response => this.stateList = response);
    userFacade.getAllUserTypes().subscribe(response => this.userTypeList = response);
  }

  ngOnInit(): void {
  }

  changeState(event: any) {
    this.userForm.get('state')?.setValue(+event.target.value);
  }

  changeType(event: any) {
    this.userForm.get('type')?.setValue(+event.target.value);
  }

}
