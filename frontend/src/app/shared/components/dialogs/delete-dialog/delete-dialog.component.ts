import { Component, Input, OnInit, OnDestroy, EventEmitter, ViewChild, ElementRef } from '@angular/core';
import { Modal } from 'bootstrap';
import { Observable, Subscriber, Subscription } from 'rxjs';


@Component({
  selector: 'app-delete-dialog',
  templateUrl: './delete-dialog.component.html',
  styleUrls: ['./delete-dialog.component.scss']
})
export class DeleteDialogComponent implements OnInit {

  @Input() title? = '';
  @Input() message? = '';
  @Input() handleDeleteEvent: Observable<any> | undefined;

  @ViewChild('deleteModal', {static:true}) private deleteModal: ElementRef | undefined;
  private subscription: Subscription | undefined;
  private myDeleteModal: Modal | undefined;
  

  constructor() { }

  ngOnInit(): void {
    this.subscription = this.handleDeleteEvent?.subscribe(() => this.openModal());
    
    // const element = document.querySelector('.delete-modal') as HTMLElement;
    const element = document.getElementById('deleteModal') as HTMLElement;
    this.myDeleteModal = new Modal(this.deleteModal?.nativeElement, {
      keyboard: false
    });

  }

  openModal() {
    this.myDeleteModal?.show();
  }
  onCloseHandled() {
    console.log('onclosehandled');
    this.myDeleteModal?.hide();
  }

  ngOnDestroy(): void {
    this.subscription?.unsubscribe();
  }
}
