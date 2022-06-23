import { Component, Inject, OnInit } from '@angular/core';
import { Film } from 'src/app/Models/film.model';
import { FilmService } from 'src/app/Services/film.service';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-addfilm',
  templateUrl: './addfilm.component.html',
  styleUrls: ['./addfilm.component.css']
})
export class AddfilmComponent implements OnInit {
  item:Film;

  constructor(private router: Router, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.item = new Film();
   }

  ngOnInit(): void {
  }

  Add() {
    this.AddFilm(this.item).subscribe(data => {
      console.log(data);
    })
    this.router.navigateByUrl('getallfilm');
  }

  AddFilm(item: Film): Observable<any> {
    return this.http.post<any>(this.baseUrl + 'film/AddFilm',item);
  }
}
