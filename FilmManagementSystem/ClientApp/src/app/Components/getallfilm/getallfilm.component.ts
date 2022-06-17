import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Film } from 'src/app/Models/film.model';
import { FilmService } from 'src/app/Services/film.service';

@Component({
  selector: 'app-getallfilm',
  templateUrl: './getallfilm.component.html',
  styleUrls: ['./getallfilm.component.css']
})
export class GetallfilmComponent {
  public films:Film[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Film[]>(baseUrl + 'film').subscribe(result => {
      this.films = result;
    }, error => console.error(error));
  }
}
