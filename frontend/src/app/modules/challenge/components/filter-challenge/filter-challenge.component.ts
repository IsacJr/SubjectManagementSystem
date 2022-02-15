import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { faMinus } from '@fortawesome/free-solid-svg-icons';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';

@Component({
  selector: 'app-filter-challenge',
  templateUrl: './filter-challenge.component.html',
  styleUrls: ['./filter-challenge.component.scss']
})
export class FilterChallengeComponent implements OnInit {

  @Input()
  public institutionInput = [] as any[];
  @Input()
  public statusInput = [] as any[];
  @Input()
  public fieldInput = [] as any[];
  @Output()
  public emitFilter =  new EventEmitter<FilterQueryParamsModel | null>();

  faMinus = faMinus;

  challengeFilterForm: FormGroup;

  filter: FilterQueryParamsModel | null = null;

  constructor(private formBuilder: FormBuilder) {
    this.challengeFilterForm = this.formBuilder.group({
      institution: null,
      status: null,
      field: null
    });
  }

  ngOnInit(): void {
  }

  changeInstitution(event: any) {
    this.challengeFilterForm.get('institution')?.setValue(+event.target.value);
    this.filter = { ...this.filter, institution: +event.target.value }
    this.doEmit();
  }

  changeStatus(event: any) {
    this.challengeFilterForm.get('status')?.setValue(+event.target.value);
    this.filter = { ...this.filter, status: +event.target.value }
    this.doEmit();
  }

  changeField(event: any) {
    this.challengeFilterForm.get('field')?.setValue(+event.target.value);
    this.filter = { ...this.filter, field: +event.target.value }
    this.doEmit();
  }

  onCleanFilter() {
    this.filter = {}
    this.cleanForm();
    this.doEmit();
  }

  private cleanForm() {
    this.challengeFilterForm.get('institution')?.setValue(null);
    this.challengeFilterForm.get('status')?.setValue(null);
    this.challengeFilterForm.get('field')?.setValue(null);
  }

  private doEmit() {
    this.emitFilter.emit(this.filter);
  }

}
