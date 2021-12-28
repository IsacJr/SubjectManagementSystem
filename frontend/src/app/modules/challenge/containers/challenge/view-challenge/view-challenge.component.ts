import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ClassroomFacade } from 'src/app/modules/classroom/classroom.facade';
import { TeamFacade } from 'src/app/modules/team/team.facade';
import { ChallengeFacade } from '../../../challenge.facade';
import { faPlus } from '@fortawesome/free-solid-svg-icons';
import { ContractFacade } from 'src/app/shared/services/contract.facade';

@Component({
  selector: 'app-view-challenge',
  templateUrl: './view-challenge.component.html',
  styleUrls: ['./view-challenge.component.scss']
})
export class ViewChallengeComponent implements OnInit {

  challenge:any = { };
  classroomList = [] as any[];
  teamList = [] as any[];

  challengeForm: FormGroup;

  faPlus = faPlus;
  
  constructor(
    private formBuilder: FormBuilder,
    private challengeFacade: ChallengeFacade,
    private classroomFacade: ClassroomFacade,
    private teamFacade: TeamFacade,
    private contractFacade: ContractFacade
  ) {
    this.challengeForm = this.formBuilder.group({
      idClassroom: null,
    });
    challengeFacade.getOne(13).subscribe(response => this.challenge = response);
    classroomFacade.getAll().subscribe(response => this.classroomList = response);
    teamFacade.getAll().subscribe(response => this.teamList = response);
  }

  ngOnInit(): void {
  }

  changeInClassroom(event: any) {
    this.challengeForm.get('idClassroom')?.setValue(+event.target.value);
  }

  changeTeam(event: any) {
    this.challengeForm.get('idTeam')?.setValue(+event.target.value);
  }

  temOptionLabel(team: any) {
    if(team){
      return team.members.map(( member: any ) => { return member.user.name; }).join(', ');
    }
    return '';
  }

  onSubmit(){
    console.log('submitted view challenge')
  }

  proposePartnership(){
    const idClassroom = this.challengeForm.get('idClassroom')?.value;
    const idChallenge = this.challenge.Id;
    this.contractFacade.proposePartnership({idClassroom, idChallenge});
  }

}
