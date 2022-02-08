import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateComponent } from './create/create.component';
import { ListComponent } from './list/list.component';
import { DetailComponent } from './detail/detail.component';
import { UpdateComponent } from './update/update.component';
import { ListItemComponent } from './list-item/list-item.component';



@NgModule({
  declarations: [
    CreateComponent,
    ListComponent,
    DetailComponent,
    UpdateComponent,
    ListItemComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ContactModule { }
