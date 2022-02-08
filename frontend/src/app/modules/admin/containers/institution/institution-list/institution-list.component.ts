import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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
    private institutionFacade: InstitutionFacade,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.subscriptions.add = this.institutionFacade.getAll().subscribe(response => this.institutionList = response);
  }

  handleVisualize() {
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/admin/institution/edit/${id}`]);
  }

  handleDelete() {
    console.log('delete event');
  }

  ngOnDestroy(): void {
    this.subscriptions.dispose();
  }

}
