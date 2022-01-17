import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { InstitutionFacade } from '../../institution/institution.facade';
import { UserFacade } from '../user.facade';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit, OnDestroy {

  readonly PAGE_TITLE_LABEL = "Lista de Usuários";
  readonly NEW_ENTITY_BUTTON_LABEL = "Novo Usuário"

  userList: any[] = [];
  institutionList: any[] = [];
  userTypeList: any[] = [];

  filter: FilterQueryParamsModel | undefined;

  subscriptions = new SubscriptionsContainer();

  constructor(
    private userFacade: UserFacade,
    private institutionFacade: InstitutionFacade,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.subscriptions.add = this.userFacade.getAll().subscribe(response => this.userList = response);
    this.subscriptions.add = this.institutionFacade.getAll().subscribe(response => this.institutionList = response);
    this.subscriptions.add = this.userFacade.getAllUserTypes().subscribe(response => this.userTypeList = response);
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
    this.subscriptions.add = this.userFacade.getAll(this.filter).subscribe(response => this.userList = response);
  }

  handleVisualize() {
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/admin/user/edit/${id}`]);
  }

  handleDelete() {
    console.log('delete event');
  }

  ngOnDestroy(): void {
    this.subscriptions.dispose();
  }

}
