import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NavigationEnd, Router, Event, NavigationStart, ActivatedRoute } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { FieldFacade } from 'src/app/modules/admin/containers/field/field.facade';
import { InstitutionFacade } from 'src/app/modules/admin/containers/institution/institution.facade';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { ClassroomFacade } from 'src/app/modules/classroom/classroom.facade';
import { PageModeEnum } from 'src/app/shared/models/pageModeEnum';
import { StatusFacade } from 'src/app/shared/services/status.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { ChallengeFacade } from '../../../challenge.facade';

@Component({
  selector: 'app-new-challenge',
  templateUrl: './new-challenge.component.html',
  styleUrls: ['./new-challenge.component.scss']
})
export class NewChallengeComponent implements OnInit, OnDestroy {

  institutionList = [] as any[];
  statusList = [] as any[];
  fieldList = [] as any[];
  inChargeList = [] as any[];
  classroomList = [] as any[];

  challengeForm: FormGroup;

  currentChallenge = {} as any;

  currentRoute = '';
  currentId = 0;

  subscriptions = new SubscriptionsContainer();

  pageModeEnum = PageModeEnum;

  unsub$ = new Subject();
  
  constructor(
    private formBuilder: FormBuilder,
    private challengeFacade: ChallengeFacade,
    private institutionFacade: InstitutionFacade,
    private statusFacade: StatusFacade,
    private fieldFacade: FieldFacade,
    private userFacade: UserFacade,
    private classroomFacade: ClassroomFacade,
    private router: Router,
    private activateRoute: ActivatedRoute
  )
  {
    this.challengeForm = this.formBuilder.group({
      title: '',
      caption: '',
      idInstitution: null,
      idField: null,
      description: '',
      material: '',
      status: null,
      idInCharge: null,
      idClassroom: null,
      idCreator: 0
    })

    this.loadInfo();

    router.events.subscribe((event: Event) => {
      if (event instanceof NavigationEnd) {
        this.currentRoute = event.url;
      }
      else if (event instanceof NavigationStart) {
        this.currentRoute = event.url;
      }
    });

    this.activateRoute.params.subscribe(params => {
      this.currentId = +params['id'];
      this.loadChallengeById();
    });
  
  }

  ngOnInit(): void {
  }

  private loadInfo(){
    this.subscriptions.add = this.institutionFacade.getAll().subscribe(response => this.institutionList = response);
    this.subscriptions.add = this.statusFacade.getAll().subscribe(response => this.statusList = response);;
    this.subscriptions.add = this.fieldFacade.getAll().subscribe(response => this.fieldList = response);
    this.subscriptions.add = this.userFacade.getAll().subscribe(response => this.inChargeList = response);
    this.subscriptions.add = this.classroomFacade.getAll().subscribe(response => this.classroomList = response);
  }

  save() {
    const challengePayload = this.challengeForm.value;
    this.subscriptions.add = this.challengeFacade.post(challengePayload).subscribe(response => console.log(response));
  }

  update() {
    const challengePayload = {id: this.currentId, ...this.challengeForm.value};
    this.challengeFacade.put(challengePayload).pipe(takeUntil(this.unsub$)).subscribe(response => console.log(response));
  }

  private loadChallengeById() {
    this.subscriptions.add = this.challengeFacade.getOne(this.currentId).subscribe(response => {
      this.currentChallenge = response
      this.loadForm();
    });
  }

  private loadForm() {
    console.log('loadForm');
    this.challengeForm.get('title')?.setValue(this.currentChallenge.title);
    this.challengeForm.get('caption')?.setValue(this.currentChallenge.caption);
    this.challengeForm.get('idInstitution')?.setValue(this.currentChallenge.idInstitution);
    this.challengeForm.get('idField')?.setValue(this.currentChallenge.idField);
    this.challengeForm.get('description')?.setValue(this.currentChallenge.description);
    this.challengeForm.get('material')?.setValue(this.currentChallenge.material);
    this.challengeForm.get('status')?.setValue(this.currentChallenge.status);
    this.challengeForm.get('idInCharge')?.setValue(this.currentChallenge.idInCharge);
    this.challengeForm.get('idClassroom')?.setValue(this.currentChallenge.idClassroom);
    this.challengeForm.get('idCreator')?.setValue(this.currentChallenge.idCreator); 
  }

  get currentPageMode() {
    if(this.currentRoute && (this.currentRoute.includes('edit')))
      return PageModeEnum.edit;
    else if(this.currentRoute && (this.currentRoute.includes('new')))
      return PageModeEnum.new;
    return PageModeEnum.view
  }

  changeInstitution(event: any) {
    this.challengeForm.get('idInstitution')?.setValue(+event.target.value);
  }

  changeField(event: any) {
    this.challengeForm.get('idField')?.setValue(+event.target.value);
  }

  changeStatus(event: any) {
    this.challengeForm.get('status')?.setValue(+event.target.value);
  }

  changeInCharge(event: any) {
    this.challengeForm.get('idInCharge')?.setValue(+event.target.value);
  }

  changeInClassroom(event: any) {
    this.challengeForm.get('idClassroom')?.setValue(+event.target.value);
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
      this.subscriptions.dispose();
  }

}
