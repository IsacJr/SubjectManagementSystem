import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { TeamFacade } from '../../team.facade';

@Component({
  selector: 'app-team-new',
  templateUrl: './team-new.component.html',
  styleUrls: ['./team-new.component.scss']
})
export class TeamNewComponent implements OnInit {

  mentorList = [] as any[];
  memberList = [] as any[];

  teamForm: FormGroup;
  
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

    this.userFacade.getAll().subscribe(response => {
      this.mentorList = response;
      this.memberList = response;
    });

  }

  ngOnInit(): void {
  }

  onSubmit() {
    const payload = this.buildPayload();
    console.log('onSubmit: ', payload);
    // this.userFacade.post(payload).subscribe(response => console.log(response));
  }

  buildPayload() {
    const payload = {
      team: {
        idMentor: this.teamForm.get('idMentor')?.value,
        solution: this.teamForm.get('solution')?.value
      },
      idUserList: []
    }
    return payload;
  }

  changeMentor(event: any) {
    this.teamForm.get('idMentor')?.setValue(+event.target.value);
  }

}
