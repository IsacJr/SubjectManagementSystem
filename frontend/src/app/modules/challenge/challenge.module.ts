import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ChallengeAPI } from './api/challenge.api';
import { ChallengeRoutes } from './challenge-routing.module';
import { ChallengeFacade } from './challenge.facade';
import { ChallengeComponent } from './containers/challenge/challenge-list/challenge.component';
import { NewChallengeComponent } from './containers/challenge/new-challenge/new-challenge.component';


@NgModule({
  declarations: [
    ChallengeComponent,
    NewChallengeComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(ChallengeRoutes)
  ],
  providers: [
    ChallengeAPI,
    ChallengeFacade
  ]
})
export class ChallengeModule { }
