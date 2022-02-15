import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { faMinus } from '@fortawesome/free-solid-svg-icons';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.scss']
})
export class FilterComponent implements OnInit {

  @Input()
  public institutionInput = [] as any[];
  @Input()
  public professorInput = [] as any[];
  @Input()
  public statusInput = [] as any[];
  @Input()
  public fieldInput = [] as any[];
  @Input()
  public userTypeInput = [] as any[];
  @Output()
  public emitFilter =  new EventEmitter<FilterQueryParamsModel | null>();

  faMinus = faMinus;

  filterForm: FormGroup;

  filter: FilterQueryParamsModel | null = null;

  constructor(private formBuilder: FormBuilder) {
    this.filterForm = this.formBuilder.group({
      institution: null,
      professor: null,
      status: null,
      field: null,
      type: null
    });
  }

  ngOnInit(): void {
  }

  changeInstitution(event: any) {
    this.filterForm.get('institution')?.setValue(+event.target.value);
    this.filter = { ...this.filter, institution: +event.target.value }
    this.doEmit();
  }

  changeProfessor(event: any) {
    this.filterForm.get('professor')?.setValue(+event.target.value);
    this.filter = { ...this.filter, professor: +event.target.value }
    this.doEmit();
  }

  changeStatus(event: any) {
    this.filterForm.get('status')?.setValue(+event.target.value);
    this.filter = { ...this.filter, status: +event.target.value }
    this.doEmit();
  }

  changeField(event: any) {
    this.filterForm.get('field')?.setValue(+event.target.value);
    this.filter = { ...this.filter, field: +event.target.value }
    this.doEmit();
  }

  changeType(event: any) {
    this.filterForm.get('type')?.setValue(+event.target.value);
    this.filter = { ...this.filter, userType: +event.target.value }
    this.doEmit();
  }

  onCleanFilter() {
    this.filter = {}
    this.cleanForm();
    this.doEmit();
  }

  private cleanForm() {
    this.filterForm.get('institution')?.setValue(null);
    this.filterForm.get('professor')?.setValue(null);
    this.filterForm.get('status')?.setValue(null);
    this.filterForm.get('field')?.setValue(null);
    this.filterForm.get('type')?.setValue(null);
  }

  private doEmit() {
    this.emitFilter.emit(this.filter);
  }

}
