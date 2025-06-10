﻿import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard/dashboard.component';
import { AuthGuard } from './guards/auth.guard';
import { LoginComponent } from './pages/auth/login/login.component';
import { VaccinationListComponent } from './pages/vaccination-list/vaccination-list.component';

const routes: Routes = [
  // Öffentlicher Login-Bereich
  { path: 'auth/login', component: LoginComponent },
  { path: 'dashboard', component: DashboardComponent },

  // Geschützter Bereich mit Dashboard und Unterseiten
  { path: 'vaccinations', component: VaccinationListComponent, canActivate: [AuthGuard] },

  // Redirect von leerem Pfad auf Dashboard
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },

  // Fallback bei ungültiger URL
  { path: '**', redirectTo: '/dashboard' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
