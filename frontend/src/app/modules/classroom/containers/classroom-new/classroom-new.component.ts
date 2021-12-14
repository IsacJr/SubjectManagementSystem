import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { SubjectFacade } from 'src/app/modules/admin/containers/subject/subject.facade';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { ClassroomFacade } from '../../classroom.facade';

@Component({
  selector: 'app-classroom-new',
  templateUrl: './classroom-new.component.html',
  styleUrls: ['./classroom-new.component.scss']
})
export class ClassroomNewComponent implements OnInit {

  classroomList = [] as any[];
  professorList = [] as any[];
  subjectList = [] as any[];

  classroomForm: FormGroup;
  
  constructor(
    private formBuilder: FormBuilder,
    private classroomFacade: ClassroomFacade,
    private professorFacade: UserFacade,
    private subjectFacade: SubjectFacade
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

      classroomFacade.getAll().subscribe(response => this.classroomList = response);
      professorFacade.getAll().subscribe(response => this.professorList = response);
      subjectFacade.getAll().subscribe(response => this.subjectList = response);
  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.classroomForm.value;
    this.classroomFacade.post(payload).subscribe(response => console.log(response));
  }

  changeProfessor(event: any) {
    this.classroomForm.get('idProfessor')?.setValue(+event.target.value);
  }

  changeSubject(event: any) {
    this.classroomForm.get('idSubject')?.setValue(+event.target.value);
  }

}
