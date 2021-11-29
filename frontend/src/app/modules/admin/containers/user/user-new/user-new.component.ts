import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-new',
  templateUrl: './user-new.component.html',
  styleUrls: ['./user-new.component.scss']
})
export class UserNewComponent implements OnInit {

  readonly PAGE_TITLE_LABEL = "Novo Usuário";
  
  constructor() { }

  ngOnInit(): void {
  }

}
