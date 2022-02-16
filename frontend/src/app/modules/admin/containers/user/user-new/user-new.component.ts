import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NavigationEnd, Router, Event, NavigationStart, ActivatedRoute } from '@angular/router';
import { PageModeEnum } from 'src/app/shared/models/pageModeEnum';
import { StateFacade } from 'src/app/shared/services/state.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { UserFacade } from '../user.facade';

@Component({
  selector: 'app-user-new',
  templateUrl: './user-new.component.html',
  styleUrls: ['./user-new.component.scss']
})
export class UserNewComponent implements OnInit, OnDestroy {

  readonly PAGE_TITLE_NEW_USER_LABEL = "Novo Usuário";
  readonly PAGE_TITLE_EDIT_USER = "Edição de Usuário"
  stateList = [] as any[];
  userTypeList = [] as any[];
  currentUser = {} as any;

  userForm: FormGroup;

  subscriptions = new SubscriptionsContainer();

  currentRoute = '';
  currentId = 0;

  pageModeEnum = PageModeEnum;

  constructor(
    private formBuilder: FormBuilder,
    private userFacade: UserFacade,
    private stateFacade: StateFacade,
    private router: Router,
    private activateRoute: ActivatedRoute
  ) {
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
    this.subscriptions.add = router.events.subscribe((event: Event) => {
      if (event instanceof NavigationEnd) {
        this.currentRoute = event.url;
      }
      else if (event instanceof NavigationStart) {
        this.currentRoute = event.url;
      }
    });

    this.activateRoute.params.subscribe(params => {
      this.currentId = +params['id'];
      this.loadUserById();
    });
  }

  ngOnInit(): void {
  }

  get currentPageMode() {
    if(this.currentRoute && (this.currentRoute.includes('edit')))
      return PageModeEnum.edit;
    else if(this.currentRoute && (this.currentRoute.includes('new')))
      return PageModeEnum.new;
    return PageModeEnum.view
  }

  get userPageLabel() {
    if(this.currentPageMode === PageModeEnum.edit)
      return this.PAGE_TITLE_EDIT_USER;
    return this.PAGE_TITLE_NEW_USER_LABEL;
  }

  onSubmit() {
    const payload = this.userForm.value;
    this.subscriptions.add = this.userFacade.post(payload).subscribe(response => console.log(response));
  }

  private loadUserById() {
    this.subscriptions.add = this.userFacade.getOne(this.currentId).subscribe(response => {
      this.currentUser = response
      this.loadForm();
    });
  }

  private loadForm() {
    this.userForm.get('name')?.setValue(this.currentUser.name);
    this.userForm.get('email')?.setValue(this.currentUser.email);
    this.userForm.get('birthday')?.setValue(this.currentUser.birthday.substring(0, 10));
    this.userForm.get('city')?.setValue(this.currentUser.city);
    this.userForm.get('password')?.setValue(this.currentUser.password);
    this.userForm.get('state')?.setValue(this.currentUser.state);
    this.userForm.get('type')?.setValue(this.currentUser.type);
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
