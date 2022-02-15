import { Component, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subject } from 'rxjs';
import { FieldFacade } from 'src/app/modules/admin/containers/field/field.facade';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { ClassroomFacade } from '../../classroom.facade';

@Component({
  selector: 'app-classroom',
  templateUrl: './classroom.component.html',
  styleUrls: ['./classroom.component.scss']
})
export class ClassroomComponent implements OnInit, OnDestroy {

  classroomList: any[] = [];
  professorList: any[] = [];
  fieldList: any[] = [];

  unsub$ = new Subject();
  private subscriptions = new SubscriptionsContainer();
  private filter: FilterQueryParamsModel | null = null;

  constructor(
    private classroomFacade: ClassroomFacade,
    private professorFacade: UserFacade,
    private fieldFacade: FieldFacade,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.subscriptions.add = this.classroomFacade.getAll().subscribe(response => this.classroomList = response);

    this.subscriptions.add = this.professorFacade.getAll().subscribe(response => this.professorList = response);
    this.subscriptions.add = this.fieldFacade.getAll().subscribe(response => this.fieldList = response);
  }

  handleFilterEmitted(evt: FilterQueryParamsModel | null) {
    this.filter = evt;
    this.doFilter();
  }

  private doFilter(){
    this.subscriptions.add = this.classroomFacade.getAll(this.filter).subscribe(response => this.classroomList = response);
  }

  handleVisualize() {
    console.log('visualize event');
  }

  handleEdit(id: number) {
    this.router.navigate([`/classroom/edit/${id}`]);
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
