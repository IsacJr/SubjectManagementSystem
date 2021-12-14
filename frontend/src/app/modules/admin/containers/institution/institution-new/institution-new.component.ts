import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { StateFacade } from 'src/app/shared/services/state.facade';
import { FieldFacade } from '../../field/field.facade';
import { InstitutionFacade } from '../institution.facade';

@Component({
  selector: 'app-institution-new',
  templateUrl: './institution-new.component.html',
  styleUrls: ['./institution-new.component.scss']
})
export class InstitutionNewComponent implements OnInit {

  institutionList = [] as any[];
  stateList = [] as any[];
  fieldList = [] as any[];

  institutionForm: FormGroup;

  constructor(
      private formBuilder: FormBuilder,
      private institutionFacade: InstitutionFacade,
      private stateFacade: StateFacade,
      private fieldFacade: FieldFacade
    ) { 
      this.institutionForm = this.formBuilder.group({
        name: '',
        employerIdentificationNumber: '',
        zipCode: '',
        street: '',
        city: '',
        state: null,
        idField: null
      });

      institutionFacade.getAll().subscribe(response => this.institutionList = response);
      stateFacade.getAll().subscribe(response => this.stateList = response);
      fieldFacade.getAll().subscribe(response => this.fieldList = response);
    }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.institutionForm.value;
    this.institutionFacade.post(payload).subscribe(response => console.log(response));
  }

  changeState(event: any) {
    this.institutionForm.get('state')?.setValue(+event.target.value);
  }

  changeField(event: any) {
    this.institutionForm.get('idField')?.setValue(+event.target.value);
  }

}
