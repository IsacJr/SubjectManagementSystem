import { Component, OnInit } from '@angular/core';
import { ClassroomFacade } from '../../classroom.facade';

@Component({
  selector: 'app-classroom',
  templateUrl: './classroom.component.html',
  styleUrls: ['./classroom.component.scss']
})
export class ClassroomComponent implements OnInit {

  classroomList: any[] = [];

  constructor(
    private classroomFacade: ClassroomFacade
  ) { }

  ngOnInit(): void {
    this.classroomFacade.getAll().subscribe(response => this.classroomList = response);
  }


}
