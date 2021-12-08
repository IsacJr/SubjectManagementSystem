import { Component, Input, OnInit, OnDestroy, EventEmitter, ViewChild, ElementRef, Output } from '@angular/core';
import { Modal } from 'bootstrap';
import { Observable, Subscriber, Subscription } from 'rxjs';


@Component({
  selector: 'app-delete-dialog',
  templateUrl: './delete-dialog.component.html',
  styleUrls: ['./delete-dialog.component.scss']
})
export class DeleteDialogComponent implements OnInit {

  @Input() title? = 'Apagar';
  @Input() message? = 'Tem certeza que deseja apagar?';
  @Input() handleDeleteEvent: Observable<any> | undefined;

  @Output() modalResponse = new EventEmitter<boolean>();

  @ViewChild('deleteModal', {static:true}) private deleteModal: ElementRef | undefined;
  private subscription: Subscription | undefined;
  private myDeleteModal: Modal | undefined;

  constructor() { }

  ngOnInit(): void {
    this.subscription = this.handleDeleteEvent?.subscribe(() => this.openModal());
    
    this.myDeleteModal = new Modal(this.deleteModal?.nativeElement, {
      keyboard: false
    });

  }

  openModal() {
    this.myDeleteModal?.show();
  }
  closeModal() {
    this.myDeleteModal?.hide();
  }

  actionModal() {
    this.modalResponse.emit(true);
    this.closeModal();
  }

  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }
}
