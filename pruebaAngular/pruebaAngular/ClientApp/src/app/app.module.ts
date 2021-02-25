import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

import { LibrosComponent } from './libros/libros.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    LibrosComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: LibrosComponent, pathMatch: 'full' },
      { path: 'libros', component: LibrosComponent, },      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
