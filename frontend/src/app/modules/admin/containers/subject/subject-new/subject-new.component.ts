import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { EducationLevelFacade } from 'src/app/shared/services/education-level.facade';
import { FieldFacade } from '../../field/field.facade';
import { SubjectFacade } from '../subject.facade';

@Component({
  selector: 'app-subject-new',
  templateUrl: './subject-new.component.html',
  styleUrls: ['./subject-new.component.scss']
})
export class SubjectNewComponent implements OnInit {

  subjectList = [] as any[];
  educatioLevelList = [] as any[];
  fieldList = [] as any[];

  subjectForm: FormGroup;
  
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
      
      subjectFacade.getAll().subscribe(response => this.subjectList = response);
      educationLevelFacade.getAll().subscribe(response => this.educatioLevelList = response);
      fieldFacade.getAll().subscribe(response => this.fieldList = response);
  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.subjectForm.value;
    this.subjectFacade.post(payload).subscribe(response => console.log(response));
  }

  changeEducationLevel(event: any) {
    this.subjectForm.get('educationLevel')?.setValue(+event.target.value);
  }

  changeField(event: any) {
    this.subjectForm.get('idField')?.setValue(+event.target.value);
  }

}
