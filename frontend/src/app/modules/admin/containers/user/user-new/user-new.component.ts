import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { UserFacade } from '../challenge.facade';

@Component({
  selector: 'app-user-new',
  templateUrl: './user-new.component.html',
  styleUrls: ['./user-new.component.scss']
})
export class UserNewComponent implements OnInit {

  readonly PAGE_TITLE_LABEL = "Novo Usuário";
  userForm: FormGroup;

  stateMock = [
    { value: 0, name: 'Acre' },
    { value: 1, name: 'Amapá' },
    { value: 2, name: 'Bahia' }
  ]

  typeMock = [
    { value: 0, name: 'Parceiro' },
    { value: 1, name: 'Professor' },
    { value: 2, name: 'Estudante' }
  ]
  
  constructor(private formBuilder: FormBuilder, private userFacade: UserFacade) {
    this.userForm = this.formBuilder.group({
      name: '',
      type: '',
      email: '',
      birthday: '',
      city: '',
      state: ''
    })
  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.userForm.value;
    console.log(payload);
    this.userFacade.post(payload).subscribe(response => console.log(response));
  }

  changeState(event: any) {
    this.userForm.get('state')?.setValue(+event.target.value);
    console.log(event.target.value);
  }

  changeType(event: any) {
    this.userForm.get('type')?.setValue(+event.target.value);
    console.log(event.target.value);
  }

}
