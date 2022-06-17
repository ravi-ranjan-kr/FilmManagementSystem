import { Component, OnInit } from '@angular/core';
import { Film } from 'src/app/Models/film.model';
import { FilmService } from 'src/app/Services/film.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-addfilm',
  templateUrl: './addfilm.component.html',
  styleUrls: ['./addfilm.component.css']
})
export class AddfilmComponent implements OnInit {
  item:Film;

  constructor(private filmService:FilmService,private router:Router) {
    this.item=new Film()
   }

  ngOnInit(): void {
  }
  Add()
  {
    this.filmService.AddFilm(this.item).subscribe(data=>
      {
        console.log(data);
      })
      this.router.navigateByUrl('film-getallfilm');

  }

}