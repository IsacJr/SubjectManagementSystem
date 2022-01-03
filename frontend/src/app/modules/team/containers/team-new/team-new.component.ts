import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { TeamFacade } from '../../team.facade';

@Component({
  selector: 'app-team-new',
  templateUrl: './team-new.component.html',
  styleUrls: ['./team-new.component.scss']
})
export class TeamNewComponent implements OnInit, OnDestroy {

  mentorList = [] as any[];
  memberList = [] as any[];
  selectedMemberList = [] as any[];

  teamForm: FormGroup;

  unsub$ = new Subject();

  public readonly isMultiple = true;
  
  constructor(
    private formBuilder: FormBuilder,
    private teamFacade: TeamFacade,
    private userFacade: UserFacade
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

  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.buildTeamPayload();
    this.teamFacade.post(payload).pipe(takeUntil(this.unsub$)).subscribe(response => console.log(response));
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

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
