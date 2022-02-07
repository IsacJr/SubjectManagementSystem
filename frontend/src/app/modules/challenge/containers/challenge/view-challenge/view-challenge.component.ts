import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ClassroomFacade } from 'src/app/modules/classroom/classroom.facade';
import { TeamFacade } from 'src/app/modules/team/team.facade';
import { ChallengeFacade } from '../../../challenge.facade';
import { faPlus } from '@fortawesome/free-solid-svg-icons';
import { ContractFacade } from 'src/app/shared/services/contract.facade';
import { ActivatedRoute, Router } from '@angular/router';
import { StatusEnumModel } from 'src/app/shared/models/StatusEnumModel';
import { ProblemChallengeFacade } from '../../../problem-challenge.facade';
import { FilterQueryParamsModel } from 'src/app/shared/models/filterQueryParamsModel';
import { Subject, takeUntil } from 'rxjs';
import { SolutionFacade } from '../../../solution.facade';


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
export class ViewChallengeComponent implements OnInit, OnDestroy {

  id = 0;
  challenge:any = { };
  classroomList = [] as any[];
  teamList = [] as any[];
  problemChallengeList = [] as any[];

  challengeForm: FormGroup;

  faPlus = faPlus;

  challengeViewMode = ChallengeViewMode;

  unsub$ = new Subject();
  
  constructor(
    private formBuilder: FormBuilder,
    private challengeFacade: ChallengeFacade,
    private classroomFacade: ClassroomFacade,
    private teamFacade: TeamFacade,
    private contractFacade: ContractFacade,
    private activateRoute: ActivatedRoute,
    private problemChallengeFacade: ProblemChallengeFacade,
    private solutionFacade: SolutionFacade,
    private router: Router
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
    this.challengeFacade.getOne(this.id).pipe(takeUntil(this.unsub$)).subscribe(response => this.challenge = response);
    this.classroomFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.classroomList = response);
    this.teamFacade.getAll().pipe(takeUntil(this.unsub$)).subscribe(response => this.teamList = response);
    
    const problemFilter = { challenge: this.id } as FilterQueryParamsModel;
    this.problemChallengeFacade.getAll(problemFilter).pipe(takeUntil(this.unsub$)).subscribe(response => this.problemChallengeList = response);
  }

  changeInClassroom(event: any) {
    this.challengeForm.get('idClassroom')?.setValue(+event.target.value);
  }

  changeTeam(event: any) {
    this.challengeForm.get('idTeam')?.setValue(+event.target.value);
  }

  temOptionLabel(team: any) {
    if(team?.members){
      return team.members.map(( member: any ) => { return member.user.name; }).join(', ');
    }
    return '-';
  }

  onSubmit(){
    if(this.currentChallengeView === ChallengeViewMode.proposing){
      this.proposePartnership();
    }else if(this.currentChallengeView === ChallengeViewMode.problem){
      this.createProblemChallenge();
    }
  }

  proposePartnership(){
    const idClassroom = this.challengeForm.get('idClassroom')?.value;
    const idChallenge = this.challenge?.id;
    const payload = { idChallenge, idClassroom };
    this.contractFacade.proposePartnership(payload).pipe(takeUntil(this.unsub$)).subscribe(response => response);
  }

  createProblemChallenge(){
    const detail = this.challengeForm.get('description')?.value;
    const idTeam = this.challengeForm.get('idTeam')?.value;
    const idChallenge = this.challenge?.id;
    const payload = { detail, idTeam, idChallenge };
    console.log('payload problem challenge: ', payload);
    this.problemChallengeFacade.post(payload).pipe(takeUntil(this.unsub$)).subscribe(response => response);
  }

  createSolution(currentProblem: any){
    const payload = { idProblem: currentProblem.id, IdTeam: currentProblem.IdTeam }
    this.solutionFacade.post(payload).subscribe(response => console.log(response));
  }

  viewSolution(currentProblem: any){
    this.router.navigate([`challenge/solution/${currentProblem.id}`]);
  }

  ngOnDestroy(): void {
      this.unsub$.next({});
      this.unsub$.complete();
  }

}
