import { Component, OnInit } from '@angular/core';
import { SubjectFacade } from '../subject.facade';

@Component({
  selector: 'app-subject-list',
  templateUrl: './subject-list.component.html',
  styleUrls: ['./subject-list.component.scss']
})
export class SubjectListComponent implements OnInit {

  subjectList: any[] = [];
  
  constructor(
    private subjectFacade: SubjectFacade
  ) { }

  ngOnInit(): void {
    this.subjectFacade.getAll().subscribe(response => this.subjectList = response);
  }

}
