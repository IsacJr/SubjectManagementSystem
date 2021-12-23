import { Component } from '@angular/core';
import { Router, Event, NavigationStart, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Sala de Aula Aberta';

  currentRoute = '';
  loginUrl = '/login';

  constructor(private router: Router) {
    this.router.events
          .subscribe(
            (event: Event) => {
              if(event instanceof NavigationEnd) {
                this.currentRoute = event.url;
              }
              else if(event instanceof NavigationStart) {
                this.currentRoute = event.url;
              }
            });
  }

  get IsPageWithMenu() {
    if(this.currentRoute && (this.currentRoute === this.loginUrl || this.currentRoute === '/')){
      return false;
    }
    return true;
  }
}
