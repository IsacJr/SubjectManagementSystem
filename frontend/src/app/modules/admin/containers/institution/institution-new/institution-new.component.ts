import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { PageModeEnum } from 'src/app/shared/models/pageModeEnum';
import { StateFacade } from 'src/app/shared/services/state.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { FieldFacade } from '../../field/field.facade';
import { InstitutionFacade } from '../institution.facade';
import { NavigationEnd, Router, Event, NavigationStart, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-institution-new',
  templateUrl: './institution-new.component.html',
  styleUrls: ['./institution-new.component.scss']
})
export class InstitutionNewComponent implements OnInit {

  institutionList = [] as any[];
  stateList = [] as any[];
  fieldList = [] as any[];

  currentUser = {} as any;

  institutionForm: FormGroup;

  subscriptions = new SubscriptionsContainer();

  currentRoute = '';
  currentId = 0;

  pageModeEnum = PageModeEnum;

  constructor(
      private formBuilder: FormBuilder,
      private institutionFacade: InstitutionFacade,
      private stateFacade: StateFacade,
      private fieldFacade: FieldFacade,
      private router: Router,
      private activateRoute: ActivatedRoute
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

      this.subscriptions.add = institutionFacade.getAll().subscribe(response => this.institutionList = response);
      this.subscriptions.add = stateFacade.getAll().subscribe(response => this.stateList = response);
      this.subscriptions.add = fieldFacade.getAll().subscribe(response => this.fieldList = response);

      this.subscriptions.add = router.events.subscribe((event: Event) => {
        if (event instanceof NavigationEnd) {
          this.currentRoute = event.url;
        }
        else if (event instanceof NavigationStart) {
          this.currentRoute = event.url;
        }
      });
  
      this.activateRoute.params.subscribe(params => {
        this.currentId = +params['id'];
        this.loadInstitutionById();
      });
    }

  ngOnInit(): void {
  }

  get currentPageMode() {
    if(this.currentRoute && (this.currentRoute.includes('edit')))
      return PageModeEnum.edit;
    else if(this.currentRoute && (this.currentRoute.includes('new')))
      return PageModeEnum.new;
    return PageModeEnum.view
  }

  private loadInstitutionById() {
    this.subscriptions.add = this.institutionFacade.getOne(this.currentId).subscribe(response => {
      this.currentUser = response
      this.loadForm();
    });
  }

  private loadForm() {
    this.institutionForm.get('name')?.setValue(this.currentUser.name);
    this.institutionForm.get('employerIdentificationNumber')?.setValue(this.currentUser.employerIdentificationNumber);
    this.institutionForm.get('zipCode')?.setValue(this.currentUser.zipCode);
    this.institutionForm.get('street')?.setValue(this.currentUser.street);
    this.institutionForm.get('city')?.setValue(this.currentUser.city);
    this.institutionForm.get('state')?.setValue(this.currentUser.state);
    this.institutionForm.get('idField')?.setValue(this.currentUser.idField);
  }

  save() {
    const institutionPayload = this.institutionForm.value;
    this.subscriptions.add = this.institutionFacade.post(institutionPayload).subscribe(response => console.log(response));
  }

  update() {
    const institutionPayload = { id: this.currentId, ...this.institutionForm.value };
    this.subscriptions.add = this.institutionFacade.put(institutionPayload).subscribe(response => console.log(response));
  }

  changeState(event: any) {
    this.institutionForm.get('state')?.setValue(+event.target.value);
  }

  changeField(event: any) {
    this.institutionForm.get('idField')?.setValue(+event.target.value);
  }

  ngOnDestroy(): void {
    this.subscriptions.dispose();
  }

}
