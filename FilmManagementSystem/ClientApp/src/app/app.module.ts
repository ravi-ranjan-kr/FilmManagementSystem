import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './Components/fetch-data/fetch-data.component';
import { AddfilmComponent } from './Components/addfilm/addfilm.component';
import { GetallfilmComponent } from './Components/getallfilm/getallfilm.component';
import { EditfilmComponent } from './Components/editfilm/editfilm.component';
import { DeletefilmbytitleComponent } from './Components/deletefilmbytitle/deletefilmbytitle.component';
import { FilmService } from './Services/film.service';
import { AppRoutingModule } from './app-route.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AddfilmComponent,
    GetallfilmComponent,
    EditfilmComponent,
    DeletefilmbytitleComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [
    FilmService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
