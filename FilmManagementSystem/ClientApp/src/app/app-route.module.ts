import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './Components/fetch-data/fetch-data.component';
import { GetallfilmComponent } from './Components/getallfilm/getallfilm.component';
import { DeletefilmbytitleComponent } from './Components/deletefilmbytitle/deletefilmbytitle.component';
import { AddfilmComponent } from './Components/addfilm/addfilm.component';
import { EditfilmComponent } from './Components/editfilm/editfilm.component';

const routes: Routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
  {path:'addfilm',component:AddfilmComponent},
  {path:'deletefilmbytitle',component:DeletefilmbytitleComponent},
  { path:'editfilm/:filmId',component:EditfilmComponent},
  {path:'getallfilm',component:GetallfilmComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
