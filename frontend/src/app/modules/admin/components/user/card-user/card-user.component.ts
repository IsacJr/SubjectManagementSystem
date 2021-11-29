import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-card-user',
  templateUrl: './card-user.component.html',
  styleUrls: ['./card-user.component.scss']
})
export class CardUserComponent implements OnInit {

  @Input() user: any;
  @Output() visualizeEvent = new EventEmitter<any>();

  constructor() { }

  ngOnInit(): void {
  }

  onVisualize() {
    this.visualizeEvent.emit(this.user.id);
  }

  onEdit() {
    this.visualizeEvent.emit(this.user.id);
  }

  onDelete() {
    this.visualizeEvent.emit(this.user.id);
  }

}
