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
    console.log(this.userForm);
    const payload = this.userForm.value;
    this.userFacade.post(payload).subscribe(response => console.log(response));
  }

}
