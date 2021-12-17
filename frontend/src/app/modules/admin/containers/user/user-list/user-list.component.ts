import { Component, OnInit } from '@angular/core';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';
import { InstitutionFacade } from '../../institution/institution.facade';
import { UserFacade } from '../user.facade';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  readonly PAGE_TITLE_LABEL = "Lista de Usuários";
  readonly NEW_ENTITY_BUTTON_LABEL = "Novo Usuário"

  userList: any[] = [];
  institutionList: any[] = [];
  userTypeList: any[] = [];

  filter: FilterQueryParamsModel | undefined;

  constructor(
    private userFacade: UserFacade,
    private institutionFacade: InstitutionFacade,
  ) { }

  ngOnInit(): void {
    this.userFacade.getAll().subscribe(response => this.userList = response);
    this.institutionFacade.getAll().subscribe(response => this.institutionList = response);
    this.userFacade.getAllUserTypes().subscribe(response => this.userTypeList = response);
  }

  handleIntitutionSelect(event: any) {
    this.filter = { ...this.filter, institution: event }
    this.doFilter();
  }

  handleUserType(event: any) {
    this.filter = { ...this.filter, userType: event }
    this.doFilter();
  }

  doFilter(){
    this.userFacade.getAll(this.filter).subscribe(response => this.userList = response);
  }

  handleVisualize() {
    console.log('visualize event');
  }

  handleEdit() {
    console.log('edit event');
  }

  handleDelete() {
    console.log('delete event');
  }

}
