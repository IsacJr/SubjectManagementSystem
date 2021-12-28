import { Component, OnInit, Output, EventEmitter, Input } from '@angular/core';
import { faEye, faEdit, faTrash } from '@fortawesome/free-solid-svg-icons';
import { Subject } from 'rxjs';

@Component({
  selector: 'app-card-action',
  templateUrl: './card-action.component.html',
  styleUrls: ['./card-action.component.scss']
})
export class CardActionComponent implements OnInit {

  @Input() id = 0;
  @Output() visualizeEvent = new EventEmitter<any>();
  @Output() editEvent = new EventEmitter<any>();
  @Output() deleteEvent = new EventEmitter<any>();

  faEye = faEye;
  faEdit = faEdit;
  faTrash = faTrash;

  deleteClick = new Subject<void>();

  constructor() { }

  ngOnInit(): void {
  }

  onVisualizeClick() {
    this.visualizeEvent.emit({id: this.id});
  }

  onEditClick() {
    this.editEvent.emit({id: this.id});
  }

  onDeleteClick() {
    console.log('card-action: onDeleteClick');
    this.deleteClick.next();
  }

}
