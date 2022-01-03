import { Component, OnDestroy, OnInit } from '@angular/core';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { InstitutionFacade } from '../institution.facade';

@Component({
  selector: 'app-institution-list',
  templateUrl: './institution-list.component.html',
  styleUrls: ['./institution-list.component.scss']
})
export class InstitutionListComponent implements OnInit, OnDestroy {

  institutionList: any[] = [];

  subscriptions = new SubscriptionsContainer();

  constructor(
    private institutionFacade: InstitutionFacade
  ) { }

  ngOnInit(): void {
    this.subscriptions.add = this.institutionFacade.getAll().subscribe(response => this.institutionList = response);
  }

  ngOnDestroy(): void {
    this.subscriptions.dispose();
  }

}
