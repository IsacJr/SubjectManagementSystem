import { Component, OnInit } from '@angular/core';
import { UserFacade } from '../challenge.facade';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  readonly PAGE_TITLE_LABEL = "Lista de Usuários";
  readonly NEW_ENTITY_BUTTON_LABEL = "Novo Usuário"

  userList: any[] = [];

  constructor(private userFacade: UserFacade) { }

  ngOnInit(): void {
    this.userFacade.getAll().subscribe(response => this.userList = response);
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
