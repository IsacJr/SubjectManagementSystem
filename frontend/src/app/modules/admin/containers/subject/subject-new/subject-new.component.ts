import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { EducationLevelFacade } from 'src/app/shared/services/education-level.facade';
import { FieldFacade } from '../../field/field.facade';
import { SubjectFacade } from '../subject.facade';

@Component({
  selector: 'app-subject-new',
  templateUrl: './subject-new.component.html',
  styleUrls: ['./subject-new.component.scss']
})
export class SubjectNewComponent implements OnInit, OnDestroy {

  subjectList = [] as any[];
  educatioLevelList = [] as any[];
  fieldList = [] as any[];

  subjectForm: FormGroup;

  unsub$ = new Subject();
  
  constructor(
    private formBuilder: FormBuilder,
    private subjectFacade: SubjectFacade,
    private educationLevelFacade: EducationLevelFacade,
    private fieldFacade: FieldFacade
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
  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.subjectForm.value;
    this.subjectFacade.post(payload).pipe(takeUntil(this.unsub$)).subscribe(response => console.log(response));
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
  }

}
