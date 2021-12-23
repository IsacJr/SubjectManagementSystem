import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { Dropdown } from 'bootstrap';
import { AuthService } from 'src/app/core/services/auth.service';

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

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
    this.myDropdown = new Dropdown(this.dropdownElement?.nativeElement, {
      autoClose: true,
      reference: this.dropdownMenu?.nativeElement
    })
  }

  get isLogoutButtonVisible() {
    return this.authService.isLoggedIn();
  }

  trigger() {
    this.myDropdown?.show();
  }

  logout() {
    this.authService.logout();
  }

}
