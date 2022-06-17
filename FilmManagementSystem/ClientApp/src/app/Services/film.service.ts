import { Inject, Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Film } from '../Models/film.model';

@Injectable({
  providedIn: 'root'
})
export class FilmService 
{
  api_path: string = 'https://localhost:44331/';
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string)
  { }
  GetAllFilm():Observable<Film[]>
  {
    return this.http.get<Film[]>(this.baseUrl +'/api/film/GetAllFilm');
  }
  GetFilmByTitle(title:string):Observable<Film>
  {
     return this.http.get<Film>(this.api_path+'/GetFilmTitle/'+title);
  }
  GetFilmByReleaseYear(releaseYear:number):Observable<Film[]>
  {
     return this.http.get<Film[]>(this.api_path+'/GetFilmByReleaseYear/'+releaseYear);
  }
  GetFilmByRating(rating:number):Observable<Film[]>
  {
     return this.http.get<Film[]>(this.api_path+'/GetFilmByRating/'+rating);
  }
  GetFilmActorId(actorId:string):Observable<Film[]>
  {
     return this.http.get<Film[]>(this.api_path+'/GetFilmActorId/'+actorId);
  }
  GetFilmCategoryId(categoryId:string):Observable<Film[]>
  {
     return this.http.get<Film[]>(this.api_path+'/GetFilmCategoryId/'+categoryId);
  }
  GetFilmLanguageId(languageId:string):Observable<Film[]>
  {
     return this.http.get<Film[]>(this.api_path+'/GetFilmLanguageId/'+languageId);
  }

  AddFilm(item:Film):Observable<any>
  {
     return this.http.post<any>(this.api_path+'/AddFilm',item);
  }
  EditFilm(item:Film):Observable<any>
  {
     return this.http.put<any>(this.api_path+'/EditFilm',item);
  }
  DeleteFilmByTitle(title:string):Observable<Film[]>
  {
     return this.http.delete<Film[]>(this.api_path+'/DeleteFilmTitle/'+title);
  }
  DeleteFilmByReleaseYear(releaseYear:number):Observable<Film[]>
  {
     return this.http.delete<Film[]>(this.api_path+'/DeleteFilmReleaseYear/'+releaseYear);
  }
  DeleteFilmByRating(rating:number):Observable<Film[]>
  {
     return this.http.delete<Film[]>(this.api_path+'/DeleteFilmRating/'+rating);
  }
}
