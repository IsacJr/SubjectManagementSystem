import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { FieldFacade } from 'src/app/modules/admin/containers/field/field.facade';
import { InstitutionFacade } from 'src/app/modules/admin/containers/institution/institution.facade';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { ClassroomFacade } from 'src/app/modules/classroom/classroom.facade';
import { StatusFacade } from 'src/app/shared/services/status.facade';
import { ChallengeFacade } from '../../../challenge.facade';

@Component({
  selector: 'app-new-challenge',
  templateUrl: './new-challenge.component.html',
  styleUrls: ['./new-challenge.component.scss']
})
export class NewChallengeComponent implements OnInit {

  institutionList = [] as any[];
  statusList = [] as any[];
  fieldList = [] as any[];
  inChargeList = [] as any[];
  classroomList = [] as any[];

  challengeForm: FormGroup;
  
  constructor(
    private formBuilder: FormBuilder,
    private challengeFacade: ChallengeFacade,
    private institutionFacade: InstitutionFacade,
    private statusFacade: StatusFacade,
    private fieldFacade: FieldFacade,
    private userFacade: UserFacade,
    private classroomFacade: ClassroomFacade
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

    institutionFacade.getAll().subscribe(response => this.institutionList = response);
    statusFacade.getAll().subscribe(response => this.statusList = response);;
    fieldFacade.getAll().subscribe(response => this.fieldList = response);
    userFacade.getAll().subscribe(response => this.inChargeList = response);
    classroomFacade.getAll().subscribe(response => this.classroomList = response);
  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.challengeForm.value;
    this.challengeFacade.post(payload).subscribe(response => console.log(response));
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

}
