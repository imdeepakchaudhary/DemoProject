import { Component, ViewChild } from '@angular/core';
import { UserService } from '../../../app/_services';
import { category } from '../../../app/_models';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { FormBuilder, FormGroup, FormGroupDirective, NgForm, Validators } from '@angular/forms';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent {
  @ViewChild('ngForm') formDirective:NgForm;
  categories: category[];
  allStudents: number = 0;
  pagination: number = 1;
  closeResult: string = '';
  loginForm: FormGroup | any;
  loading = false;
  submitted = false;
  id: number;
  constructor(
   
    private _service: UserService, private modalService: NgbModal, private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.myFormValues();

    
    this.fetchStudents();
    console.log(this.fetchStudents());
  }
  myFormValues() {
    this.loginForm = this.formBuilder.group({
      id: [this.id],
      name: ['', Validators.required],
      status: ['', Validators.required],
      description:['', Validators.required]
    });
  }
  fetchStudents() {
    this._service.getAllCategories(this.pagination).subscribe((res: any) => {
      this.categories = res as category[];
      this.allStudents = this.categories[0].totalPages;
      console.log(res.totalPages);
    });
  }
  renderPage(event: number) {
    this.pagination = event;
    this.fetchStudents();
  }
  get f() { return this.loginForm.controls; }

  open(content: any, id: number) {
    this.id = id;
   
    this.submitted = false;
   this.loginForm.markAsPristine();
    this.loginForm.markAsUntouched();
    this.loginForm.updateValueAndValidity();
    this.loginForm.reset();

    for (let control in this.loginForm.controls) {
      this.loginForm.controls[control].setErrors(null);
    }

    if (id != null) {
      this.getCategory(id);
    }
    this.loading = false;
    console.log(id);
    this.modalService.open(content, { ariaLabelledBy: 'modal-basic-title', backdrop: 'static', keyboard: false }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  private getCategory(id: number) {
    this._service.getCategory(id).subscribe({
      next: (data: any) => {
        console.log(data.name);
        this.loginForm.patchValue(data);
        //this.f.description.vaue = data.description;
        
      },
      error: (err: any) => {
        console.log(err.error);
        // this.alertService.error(error);
        this.loading = false;
      }
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
 
  onSubmit(formDirective: FormGroupDirective) {
    this.submitted = false;
    
    console.log(this.loginForm.getRawValue());
    // stop here if form is invalid
    if (this.loginForm.invalid) {
      this.submitted = true;
      return;
    }
   
    
   // formDirective.resetForm();
    //this.loginForm.reset();
    this.loading = true;
    this._service.AddCategory(this.loginForm.getRawValue())
      //.pipe(first())
      .subscribe({
        next: (data: any) => {
        //  this.router.navigate([this.returnUrl]);
          this.modalService.dismissAll();
          this.fetchStudents()
          this.submitted = true;
        },
        error: (err: any) => {
          console.log(err.error);
          // this.alertService.error(error);
          this.loading = false;
        }
      });
  }
}
