import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-filter-user',
  templateUrl: './filter-user.component.html',
  styleUrls: ['./filter-user.component.scss']
})
export class FilterUserComponent implements OnInit {

  @Input()
  public institutionInput = [] as any[];
  @Input()
  public userTypeInput = [] as any[];
  @Output()
  public selectedInstitution =  new EventEmitter<any>();
  @Output()
  public selectedUserType =  new EventEmitter<any>();

  userFilterForm: FormGroup;

  constructor(private formBuilder: FormBuilder) {
    this.userFilterForm = this.formBuilder.group({
      institution: null,
      type: null
    });
  }

  ngOnInit(): void {
  }

  changeInstitution(event: any) {
    this.userFilterForm.get('institution')?.setValue(+event.target.value);
    console.log(event.target.value);
  }

  changeType(event: any) {
    this.userFilterForm.get('type')?.setValue(+event.target.value);
    console.log(event.target.value);
  }

}
