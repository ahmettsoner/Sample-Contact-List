import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Common/Layout/header/header.component';
import { AboutComponent } from './Common/Pages/about/about.component';
import { ContactModule } from './Modules/contact/contact.module';
import { PersonModule } from './Modules/person/person.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    PersonModule,
    ContactModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
