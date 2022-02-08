import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { TeamFacade } from '../../team.facade';
import { NavigationEnd, Router, Event, NavigationStart, ActivatedRoute } from '@angular/router';
import { PageModeEnum } from 'src/app/shared/models/pageModeEnum';

@Component({
  selector: 'app-team-new',
  templateUrl: './team-new.component.html',
  styleUrls: ['./team-new.component.scss']
})
export class TeamNewComponent implements OnInit, OnDestroy {

  mentorList = [] as any[];
  memberList = [] as any[];
  selectedMemberList = [] as any[];

  currentTeam = {} as any;

  currentRoute = '';
  currentId = 0;

  pageModeEnum = PageModeEnum;

  teamForm: FormGroup;

  unsub$ = new Subject();
  subscriptions = new SubscriptionsContainer();

  public readonly isMultiple = true;
  
  constructor(
    private formBuilder: FormBuilder,
    private teamFacade: TeamFacade,
    private userFacade: UserFacade,
    private router: Router,
    private activateRoute: ActivatedRoute
  ) {
    this.teamForm = this.formBuilder.group({
      idMentor: null,
      solution: '',
      idUserList: null
    });

    this.userFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => {
      this.mentorList = response;
      this.memberList = response;
    });

    this.subscriptions.add = router.events.subscribe((event: Event) => {
      if (event instanceof NavigationEnd) {
        this.currentRoute = event.url;
      }
      else if (event instanceof NavigationStart) {
        this.currentRoute = event.url;
      }
    });

    this.subscriptions.add = this.activateRoute.params.subscribe(params => {
      this.currentId = +params['id'];
      this.loadTeamById();
    });

  }

  ngOnInit(): void {
  }

  get currentPageMode() {
    if(this.currentRoute && (this.currentRoute.includes('edit')))
      return PageModeEnum.edit;
    else if(this.currentRoute && (this.currentRoute.includes('new')))
      return PageModeEnum.new;
    return PageModeEnum.view
  }

  private loadTeamById() {
    this.subscriptions.add = this.teamFacade.getOne(this.currentId).subscribe(response => {
      this.currentTeam = response
      this.loadForm();
    });
  }

  private loadForm() {
    this.teamForm.get('idMentor')?.setValue(this.currentTeam.idMentor);
    this.teamForm.get('solution')?.setValue(this.currentTeam.solution);
    this.teamForm.get('idUserList')?.setValue(this.currentTeam.idUserList);
  }

  private loadFormSelected(){

  }

  buildTeamPayload() {
    const idUserList = this.selectedMemberList.map(user => user.id);

    const payload = {
      team: {
        idMentor: this.teamForm.get('idMentor')?.value,
        solution: this.teamForm.get('solution')?.value
      },
      idUserList
    }

    return payload;
  }

  changeMentor(event: any) {
    this.teamForm.get('idMentor')?.setValue(+event.target.value);
  }

  save() {
    const teamPayload = this.buildTeamPayload();
    this.teamFacade.post(teamPayload).pipe(takeUntil(this.unsub$)).subscribe(response => console.log(response));
  }

  update() {
    const teamPayload = this.buildTeamPayload();
    this.teamFacade.put(teamPayload).pipe(takeUntil(this.unsub$)).subscribe(response => console.log(response));
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();

      this.subscriptions.dispose();
  }

}
