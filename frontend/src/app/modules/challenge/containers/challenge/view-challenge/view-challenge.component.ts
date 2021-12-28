import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ClassroomFacade } from 'src/app/modules/classroom/classroom.facade';
import { TeamFacade } from 'src/app/modules/team/team.facade';
import { ChallengeFacade } from '../../../challenge.facade';
import { faPlus } from '@fortawesome/free-solid-svg-icons';
import { ContractFacade } from 'src/app/shared/services/contract.facade';
import { ActivatedRoute } from '@angular/router';
import { StatusEnumModel } from 'src/app/shared/models/StatusEnumModel';


enum ChallengeViewMode {
  standard,
  proposing,
  problem
}
@Component({
  selector: 'app-view-challenge',
  templateUrl: './view-challenge.component.html',
  styleUrls: ['./view-challenge.component.scss']
})
export class ViewChallengeComponent implements OnInit {

  id = 0;
  challenge:any = { };
  classroomList = [] as any[];
  teamList = [] as any[];

  challengeForm: FormGroup;

  faPlus = faPlus;

  challengeViewMode = ChallengeViewMode;
  
  constructor(
    private formBuilder: FormBuilder,
    private challengeFacade: ChallengeFacade,
    private classroomFacade: ClassroomFacade,
    private teamFacade: TeamFacade,
    private contractFacade: ContractFacade,
    private activateRoute: ActivatedRoute
  ) {
    this.challengeForm = this.formBuilder.group({
      idClassroom: null,
      description: '',
      idTeam: null
    });
    
  }

  ngOnInit(): void {
    this.activateRoute.params.subscribe(params => {
      this.id = +params['id'];
      this.loadInformation();
    });
  }

  get currentChallengeView(): ChallengeViewMode {
    if(this.challenge?.status === StatusEnumModel.notStarted)
      return ChallengeViewMode.proposing;
    else if(this.challenge?.status === StatusEnumModel.onProgress)
      return ChallengeViewMode.problem;
    
    return ChallengeViewMode.standard;
  }

  loadInformation(){
    this.challengeFacade.getOne(this.id).subscribe(response => this.challenge = response);
    this.classroomFacade.getAll().subscribe(response => this.classroomList = response);
    this.teamFacade.getAll().subscribe(response => this.teamList = response);
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
    if(this.currentChallengeView === ChallengeViewMode.proposing){
      this.proposePartnership();
    }
  }

  proposePartnership(){
    const IdClassroom = this.challengeForm.get('idClassroom')?.value;
    const IdChallenge = this.challenge?.id;
    const payload = { IdChallenge, IdClassroom };
    this.contractFacade.proposePartnership(payload).subscribe(response => response);
  }

}
