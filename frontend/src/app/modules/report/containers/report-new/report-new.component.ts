import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { UserFacade } from 'src/app/modules/admin/containers/user/user.facade';
import { ChallengeFacade } from 'src/app/modules/challenge/challenge.facade';
import { ProblemChallengeFacade } from 'src/app/modules/challenge/problem-challenge.facade';
import { SubscriptionsContainer } from 'src/app/shared/utils/subscriptions-container';
import { ReportFacade } from '../../report.facade';

@Component({
  selector: 'app-report-new',
  templateUrl: './report-new.component.html',
  styleUrls: ['./report-new.component.scss']
})
export class ReportNewComponent implements OnInit, OnDestroy {

  challengeList = [] as any[];
  userList = [] as any[];
  problemChallengeList = [] as any[];

  reportForm: FormGroup;

  subscriptions = new SubscriptionsContainer();
  
  constructor(
    private formBuilder: FormBuilder,
    private reportFacade: ReportFacade,
    private challengeFacade: ChallengeFacade,
    private userFacade: UserFacade,
    private problemChallengeFacade: ProblemChallengeFacade
  ) {
    this.reportForm = this.formBuilder.group({
      description: '',
      idChallenge: null,
      idProblemChallenge: null,
      idAuthor: null
    });

    this.subscriptions.add = challengeFacade.getAll().subscribe(response => this.challengeList = response);
    this.subscriptions.add = userFacade.getAll().subscribe(response => this.userList = response);
    this.subscriptions.add = problemChallengeFacade.getAll().subscribe(response => this.problemChallengeList = response);
  }

  ngOnInit(): void {
  }

  onSubmit() {
    const { description, idProblemChallenge, idAuthor } = this.reportForm.value;
    this.subscriptions.add = this.reportFacade.post({ description, idProblemChallenge, idAuthor }).subscribe(response => console.log(response));
  }

  changeChallenge(event: any) {
    this.reportForm.get('idChallenge')?.setValue(+event.target.value);
  }

  problemChangeChallenge(event: any) {
    this.reportForm.get('idProblemChallenge')?.setValue(+event.target.value);
  }

  changeAuthor(event: any) {
    this.reportForm.get('idAuthor')?.setValue(+event.target.value);
  }

  ngOnDestroy(): void {
      this.subscriptions.dispose();
  }

}
