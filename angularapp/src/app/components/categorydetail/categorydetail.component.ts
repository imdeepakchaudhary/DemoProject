import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-categorydetail',
  templateUrl: './categorydetail.component.html',
  styleUrls: ['./categorydetail.component.css']
})
export class CategorydetailComponent {
  @ViewChild('mymodal') modal: ElementRef
}
