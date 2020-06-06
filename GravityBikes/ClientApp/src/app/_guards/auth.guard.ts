import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authservice: AuthService, private router: Router, private alertify: AlertifyService) {}
  canActivate(): boolean {
    if (this.authservice.loggedIn) {
    return true;
    }
    this.alertify.error('You dont have acces to visit this page');
    this.router.navigate(['/home']);
    return false;
  }
}
