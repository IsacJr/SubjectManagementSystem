import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { PageModeEnum } from 'src/app/shared/models/pageModeEnum';
import { EducationLevelFacade } from 'src/app/shared/services/education-level.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { FieldFacade } from '../../field/field.facade';
import { SubjectFacade } from '../subject.facade';
import { NavigationEnd, Router, Event, NavigationStart, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-subject-new',
  templateUrl: './subject-new.component.html',
  styleUrls: ['./subject-new.component.scss']
})
export class SubjectNewComponent implements OnInit, OnDestroy {

  subjectList = [] as any[];
  educatioLevelList = [] as any[];
  fieldList = [] as any[];
  currentSubject = {} as any;

  subjectForm: FormGroup;

  unsub$ = new Subject();
  subscriptions = new SubscriptionsContainer();

  currentRoute = '';
  currentId = 0;

  pageModeEnum = PageModeEnum;
  
  constructor(
    private formBuilder: FormBuilder,
    private subjectFacade: SubjectFacade,
    private educationLevelFacade: EducationLevelFacade,
    private fieldFacade: FieldFacade,
    private router: Router,
    private activateRoute: ActivatedRoute
  ){
      this.subjectForm = this.formBuilder.group({
        name: '',
        syllabus: '',
        level: null,
        idField: null
      });
      
      subjectFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.subjectList = response);
      educationLevelFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.educatioLevelList = response);
      fieldFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.fieldList = response);

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

  private loadUserById() {
    this.subscriptions.add = this.subjectFacade.getOne(this.currentId).subscribe(response => {
      this.currentSubject = response
      this.loadForm();
    });
  }

  private loadForm() {
    this.subjectForm.get('name')?.setValue(this.currentSubject.name);
    this.subjectForm.get('syllabus')?.setValue(this.currentSubject.syllabus);
    this.subjectForm.get('level')?.setValue(this.currentSubject.level);
    this.subjectForm.get('idField')?.setValue(this.currentSubject.idField);
  }

  save() {
    const subjectPayload = this.subjectForm.value;
    this.subjectFacade.post(subjectPayload).pipe(takeUntil(this.unsub$)).subscribe(response => console.log(response));
  }

  update() {
    const subjectPayload = { id: this.currentId, ...this.subjectForm.value };
    this.subjectFacade.put(subjectPayload).pipe(takeUntil(this.unsub$)).subscribe(response => console.log(response));
  }

  changeEducationLevel(event: any) {
    this.subjectForm.get('educationLevel')?.setValue(+event.target.value);
  }

  changeField(event: any) {
    this.subjectForm.get('idField')?.setValue(+event.target.value);
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();

      this.subscriptions.dispose();
  }

}
