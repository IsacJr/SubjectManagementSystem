import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { FieldFacade } from 'src/app/modules/admin/containers/field/field.facade';
import { InstitutionFacade } from 'src/app/modules/admin/containers/institution/institution.facade';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';
import { StatusFacade } from 'src/app/shared/services/status.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { ChallengeFacade } from '../../../challenge.facade';


@Component({
  selector: 'app-challenge',
  templateUrl: './challenge.component.html',
  styleUrls: ['./challenge.component.scss']
})
export class ChallengeComponent implements OnInit, OnDestroy {

  challengeList: any[] = [];
  
  institutionList: any[] = [];
  statusList: any[] = [];
  fieldList: any[] = [];

  private unsub$ = new Subject();
  private subscriptions = new SubscriptionsContainer();
  private filter: FilterQueryParamsModel | null = null;

  constructor(
    private challengeFacade: ChallengeFacade,
    private institutionFacade: InstitutionFacade,
    private statusFacade: StatusFacade,
    private fieldFacade: FieldFacade,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.challengeFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.challengeList = response);
    
    this.subscriptions.add = this.institutionFacade.getAll().subscribe(response => this.institutionList = response);
    this.subscriptions.add = this.statusFacade.getAll().subscribe(response => this.statusList = response);
    this.subscriptions.add = this.fieldFacade.getAll().subscribe(response => this.fieldList = response);
  }

  handleFilterEmitted(evt: FilterQueryParamsModel | null) {
    this.filter = evt;
    this.doFilter();
  }

  private doFilter(){
    this.subscriptions.add = this.challengeFacade.getAll(this.filter).subscribe(response => this.challengeList = response);
  }

  handleVisualize(evt: any) {
    const { id } = evt;
    this.router.navigate([`/challenge/view/${id}`]);
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/challenge/edit/${id}`]);
  }

  handleDelete() {
    console.log('delete event');
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
      this.subscriptions.dispose();
  }

}
