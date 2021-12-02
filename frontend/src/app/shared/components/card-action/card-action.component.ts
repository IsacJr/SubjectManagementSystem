import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-card-action',
  templateUrl: './card-action.component.html',
  styleUrls: ['./card-action.component.scss']
})
export class CardActionComponent implements OnInit {

  @Output() visualizeEvent = new EventEmitter<any>();
  @Output() editEvent = new EventEmitter<any>();
  @Output() deleteEvent = new EventEmitter<any>();
  
  constructor() { }

  ngOnInit(): void {
  }

  onVisualizeClick() {
    this.visualizeEvent.emit({});
  }

  onEditClick() {
    this.editEvent.emit({});
  }

  onDeleteClick() {
    this.deleteEvent.emit({});
  }

}
