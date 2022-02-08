import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListComponent } from './list/list.component';
import { CreateComponent } from './create/create.component';
import { UpdateComponent } from './update/update.component';
import { DetailComponent } from './detail/detail.component';
import { ListItemComponent } from './list-item/list-item.component';



@NgModule({
  declarations: [
    ListComponent,
    CreateComponent,
    UpdateComponent,
    DetailComponent,
    ListItemComponent
  ],
  imports: [
    CommonModule
  ]
})
export class PersonModule { }
