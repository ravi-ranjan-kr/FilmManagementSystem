import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Film } from '../../Models/film.model';
@Component({
  selector: 'app-editfilm',
  templateUrl: './editfilm.component.html',
  styleUrls: ['./editfilm.component.css']
})
export class EditfilmComponent implements OnInit {
  public film: Film;
  item = Film;
  constructor(private http: HttpClient, private router: ActivatedRoute, @Inject('BASE_URL') private baseUrl: string) {
    this.item = new Film();
  }

  ngOnInit(): void {
    this.getCurrentData(this.router.snapshot.params.filmId).subscribe((result) => {
      this.film = result;
      console.log(result)
    })
  }

  getCurrentData(filmId) {
    return this.http.get < Film>(`${this.baseUrl} / ${filmId}`)
  }

}
