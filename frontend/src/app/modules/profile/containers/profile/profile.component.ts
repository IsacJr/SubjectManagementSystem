import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { AuthService } from 'src/app/core/services/auth.service';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { StateFacade } from 'src/app/shared/services/state.facade';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit, OnDestroy {

  stateList = [] as any[];
  userTypeList = [] as any[];
  currentUser = {} as any;

  userForm: FormGroup;

  unsub$ = new Subject();
  
  constructor(private formBuilder: FormBuilder, private userFacade: UserFacade, private stateFacade: StateFacade, private authService: AuthService) {
    this.userForm = this.formBuilder.group({
      name: '',
      type: null,
      email: '',
      birthday: '',
      city: '',
      state: null,
      password: ''
    });

    stateFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.stateList = response);
    userFacade.getAllUserTypes().pipe(takeUntil(this.unsub$)).subscribe(response => this.userTypeList = response);
    this.loadInfoToForm();
    
  }

  ngOnInit(): void {
  }

  changeState(event: any) {
    this.userForm.get('state')?.setValue(+event.target.value);
  }

  changeType(event: any) {
    this.userForm.get('type')?.setValue(+event.target.value);
  }

  loadInfoToForm() {
    const userEmail = this.authService.getUserInfo();
    this.userFacade.getUserByEmail({email: userEmail}).pipe(takeUntil(this.unsub$)).subscribe(response => {
      this.currentUser = response;

      this.userForm.get('name')?.setValue(this.currentUser.name);
      this.userForm.get('email')?.setValue(this.currentUser.email);
      this.userForm.get('birthday')?.setValue(this.currentUser.birthday);
      this.userForm.get('city')?.setValue(this.currentUser.city);
      this.userForm.get('password')?.setValue(this.currentUser.password);
      this.userForm.get('state')?.setValue(this.currentUser.state);
      this.userForm.get('type')?.setValue(this.currentUser.type);
    });
  }

  buildPayload(){
    
      this.currentUser.name = this.userForm.get('name')?.value,
      this.currentUser.email = this.userForm.get('email')?.value,
      this.currentUser.birthday = this.userForm.get('birthday')?.value,
      this.currentUser.city = this.userForm.get('city')?.value,
      this.currentUser.password = this.userForm.get('password')?.value,
      this.currentUser.state = this.userForm.get('state')?.value,
      this.currentUser.type = this.userForm.get('type')?.value

      return this.currentUser;
  }

  onSubmit() {
    const payload = this.buildPayload();
    this.userFacade.put(payload).pipe(takeUntil(this.unsub$)).subscribe(response => response);
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
