import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { FieldFacade } from 'src/app/modules/admin/containers/field/field.facade';
import { InstitutionFacade } from 'src/app/modules/admin/containers/institution/institution.facade';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { TeamFacade } from '../../team.facade';

@Component({
  selector: 'app-team',
  templateUrl: './team.component.html',
  styleUrls: ['./team.component.scss']
})
export class TeamComponent implements OnInit, OnDestroy {

  teamList: any[] = [];

  institutionList: any[] = [];
  fieldList: any[] = [];

  private unsub$ = new Subject();
  private subscriptions = new SubscriptionsContainer();
  private filter: FilterQueryParamsModel | null = null;

  constructor(
    private teamFacade: TeamFacade,
    private institutionFacade: InstitutionFacade,
    private fieldFacade: FieldFacade,
    private router: Router
  ) {
      this.teamFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.teamList = response);

      this.subscriptions.add = institutionFacade.getAll().subscribe(response => this.institutionList = response);
      this.subscriptions.add = fieldFacade.getAll().subscribe(response => this.fieldList = response);
  }

  ngOnInit(): void {
  }

  handleFilterEmitted(evt: FilterQueryParamsModel | null) {
    this.filter = evt;
    this.doFilter();
  }

  private doFilter(){
    this.subscriptions.add = this.teamFacade.getAll(this.filter).subscribe(response => this.teamList = response);
  }

  handleVisualize() {
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/team/edit/${id}`]);
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
