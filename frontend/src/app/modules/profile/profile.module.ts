import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ProfileRoutes } from './profile-routing.module';
import { ProfileComponent } from './containers/profile/profile.component';


@NgModule({
  declarations: [
    ProfileComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(ProfileRoutes)
  ],
  providers: [
    
  ]
})
export class ProfileModule { }
