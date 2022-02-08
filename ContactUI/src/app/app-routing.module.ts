import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent as PersonList } from './Modules/person/list/list.component';
import { ListComponent as ContactList } from './Modules/contact/list/list.component';
import { AboutComponent } from './Common/Pages/about/about.component';

const routes: Routes = [
  {path: "persons", component:PersonList},
  {path: "contacts", component:ContactList},
  {path: "about", component:AboutComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
