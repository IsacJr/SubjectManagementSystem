import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-card-regular',
  templateUrl: './card-regular.component.html',
  styleUrls: ['./card-regular.component.scss']
})
export class CardRegularComponent implements OnInit {

  @Input() isTitleVisible = true;
  
  constructor() { }

  ngOnInit(): void {
  }

}
