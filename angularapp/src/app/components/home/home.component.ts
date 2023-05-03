import { Component, ElementRef } from '@angular/core';
import { first } from 'rxjs/operators';

import { User } from '../../_models';
import { UserService, AuthenticationService } from '../../_services';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { Modal } from 'bootstrap';
@Component({ templateUrl: './home.component.html' })
export class HomeComponent {
  currentUser: User;
  userFromApi: User;
  closeResult: string = '';
  constructor(
    private userService: UserService,
    private authenticationService: AuthenticationService, private modalService: NgbModal
  ) {
    this.currentUser = this.authenticationService.currentUserValue;
  }

  ngOnInit() {
    //this.userService.getById(this.currentUser.id).pipe(first()).subscribe(user => {
    //  this.userFromApi = user;
    //});
  }
  show(modalRef: ElementRef) {
    const modal = new Modal(modalRef.nativeElement);
    this.modalService.open(modal, { ariaLabelledBy: 'modal-basic-title' }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });

    //modal.show();
  }
  open(content: any) {

    this.modalService.open(content, { ariaLabelledBy: 'modal-basic-title' }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }
}
