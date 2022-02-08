import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { NavigationEnd, Router, Event, NavigationStart, ActivatedRoute } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { SubjectFacade } from 'src/app/modules/admin/containers/subject/subject.facade';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { PageModeEnum } from 'src/app/shared/models/pageModeEnum';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { ClassroomFacade } from '../../classroom.facade';

@Component({
  selector: 'app-classroom-new',
  templateUrl: './classroom-new.component.html',
  styleUrls: ['./classroom-new.component.scss']
})
export class ClassroomNewComponent implements OnInit, OnDestroy {

  classroomList = [] as any[];
  professorList = [] as any[];
  subjectList = [] as any[];
  currentClassroom = {} as any;

  classroomForm: FormGroup;

  subscriptions = new SubscriptionsContainer();
  unsub$ = new Subject();

  currentRoute = '';
  currentId = 0;

  pageModeEnum = PageModeEnum;
  
  constructor(
    private formBuilder: FormBuilder,
    private classroomFacade: ClassroomFacade,
    private professorFacade: UserFacade,
    private subjectFacade: SubjectFacade,
    private router: Router,
    private activateRoute: ActivatedRoute
  ){
      this.classroomForm = this.formBuilder.group({
        description: '',
        startDate: null,
        endDate: null,
        schedule: '',
        room: '',
        idProfessor: null,
        year: 0,
        semester: '',
        spotAvailable: 0,
        classPlan: '',
        idSubject: null
      });

      classroomFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.classroomList = response);
      professorFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.professorList = response);
      subjectFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.subjectList = response);

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
        this.loadClassroomById();
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

  save() {
    const classroomPayload = this.classroomForm.value;
    this.classroomFacade.post(classroomPayload).subscribe(response => console.log(response));
  }

  update() {
    const classroomPayload = {id: this.currentId, ...this.classroomForm.value};
    this.classroomFacade.put(classroomPayload).subscribe(response => console.log(response));
  }

  private loadClassroomById() {
    this.subscriptions.add = this.classroomFacade.getOne(this.currentId).subscribe(response => {
      this.currentClassroom = response
      this.loadForm();
    });
  }

  private loadForm() {
    this.classroomForm.get('description')?.setValue(this.currentClassroom.description);
    this.classroomForm.get('startDate')?.setValue(this.currentClassroom.startDate.substring(0, 10));
    this.classroomForm.get('endDate')?.setValue(this.currentClassroom.endDate.substring(0, 10));
    this.classroomForm.get('schedule')?.setValue(this.currentClassroom.schedule);
    this.classroomForm.get('room')?.setValue(this.currentClassroom.room);
    this.classroomForm.get('idProfessor')?.setValue(this.currentClassroom.idProfessor);
    this.classroomForm.get('year')?.setValue(this.currentClassroom.year);
    this.classroomForm.get('semester')?.setValue(this.currentClassroom.semester);
    this.classroomForm.get('spotAvailable')?.setValue(this.currentClassroom.spotAvailable);
    this.classroomForm.get('classPlan')?.setValue(this.currentClassroom.classPlan);
    this.classroomForm.get('idSubject')?.setValue(this.currentClassroom.idSubject);
  }

  changeProfessor(event: any) {
    this.classroomForm.get('idProfessor')?.setValue(+event.target.value);
  }

  changeSubject(event: any) {
    this.classroomForm.get('idSubject')?.setValue(+event.target.value);
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
