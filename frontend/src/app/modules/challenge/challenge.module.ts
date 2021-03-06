import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { ContractAPI } from 'src/app/shared/api/contract.api';
import { StatusAPI } from 'src/app/shared/api/status.api';
import { ContractFacade } from 'src/app/shared/services/contract.facade';
import { StatusFacade } from 'src/app/shared/services/status.facade';
import { SharedModule } from 'src/app/shared/shared.module';
import { FieldAPI } from '../admin/containers/field/api/field.api';
import { FieldFacade } from '../admin/containers/field/field.facade';
import { InstitutionAPI } from '../admin/containers/institution/api/institution.api';
import { InstitutionFacade } from '../admin/containers/institution/institution.facade';
import { UserAPI } from '../admin/containers/user/api/user.api';
import { UserFacade } from '../admin/containers/user/user.facade';
import { ClassroomAPI } from '../classroom/api/classroom.api';
import { ClassroomFacade } from '../classroom/classroom.facade';
import { TeamAPI } from '../team/api/team.api';
import { TeamFacade } from '../team/team.facade';
import { ChallengeAPI } from './api/challenge.api';
import { ProblemChallengeAPI } from './api/problem-challenge.api';
import { ChallengeRoutes } from './challenge-routing.module';
import { ChallengeFacade } from './challenge.facade';
import { ChallengeComponent } from './containers/challenge/challenge-list/challenge.component';
import { NewChallengeComponent } from './containers/challenge/new-challenge/new-challenge.component';
import { ViewChallengeComponent } from './containers/challenge/view-challenge/view-challenge.component';
import { ProblemChallengeListComponent } from './containers/problem-challenge/problem-challenge-list/problem-challenge-list.component';
import { ProblemChallengeFacade } from './problem-challenge.facade';
import { SolutionViewComponent } from './containers/solution/solution-view/solution-view.component';
import { SolutionAPI } from './api/solution.api';
import { SolutionFacade } from './solution.facade';
import { StageAPI } from './api/stage.api';
import { StageFacade } from './stage.facade';
import { SolutionStageUpdateCardComponent } from './components/solution-stage-update-card/solution-stage-update-card.component';
import { FilterChallengeComponent } from './components/filter-challenge/filter-challenge.component';


@NgModule({
  declarations: [
    ChallengeComponent,
    NewChallengeComponent,
    ViewChallengeComponent,
    ProblemChallengeListComponent,
    SolutionViewComponent,
    SolutionStageUpdateCardComponent,
    FilterChallengeComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule,
    RouterModule.forChild(ChallengeRoutes)
  ],
  providers: [
    ChallengeAPI,
    ChallengeFacade,
    InstitutionAPI,
    InstitutionFacade,
    FieldAPI,
    FieldFacade,
    UserAPI,
    UserFacade,
    ClassroomAPI,
    ClassroomFacade,
    StatusAPI,
    StatusFacade,
    TeamAPI,
    TeamFacade,
    ProblemChallengeAPI,
    ProblemChallengeFacade,
    ContractAPI,
    ContractFacade,
    SolutionAPI,
    SolutionFacade,
    StageAPI,
    StageFacade
  ]
})
export class ChallengeModule { }
