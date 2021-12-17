import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { Dropdown } from 'bootstrap';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  @Input() IsVisible = false;
  
  @ViewChild('navbarDropdownMenuLink', {static:true}) private dropdownElement: ElementRef | undefined;
  @ViewChild('ulmenu', {static:true}) private dropdownMenu: ElementRef | undefined;
  private myDropdown: Dropdown | undefined;


  ngOnInit(): void {
    this.myDropdown = new Dropdown(this.dropdownElement?.nativeElement, {
      autoClose: true,
      reference: this.dropdownMenu?.nativeElement
    })
  }

  trigger() {
    this.myDropdown?.show();
  }

}
