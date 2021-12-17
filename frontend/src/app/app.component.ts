import { Component } from '@angular/core';
import { Router, NavigationStart, Event as NavigationEvent } from '@angular/router';

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
            (event: NavigationEvent) => {
              if(event instanceof NavigationStart) {
                console.log(event.url);
                this.currentRoute = event.url;
              }
            });
  }

  get IsPageWithMenu() {
    if(this.currentRoute && this.currentRoute === this.loginUrl){
      return false;
    }
    return true;
  }
}
