import { Component, OnInit } from '@angular/core';
import { InstitutionFacade } from '../institution.facade';

@Component({
  selector: 'app-institution-list',
  templateUrl: './institution-list.component.html',
  styleUrls: ['./institution-list.component.scss']
})
export class InstitutionListComponent implements OnInit {

  institutionList: any[] = [];

  constructor(
    private institutionFacade: InstitutionFacade
  ) { }

  ngOnInit(): void {
    this.institutionFacade.getAll().subscribe(response => this.institutionList = response);
  }

}
