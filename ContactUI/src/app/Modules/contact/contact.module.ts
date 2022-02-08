import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CreateComponent } from './create/create.component';
import { ListComponent } from './list/list.component';
import { DetailComponent } from './detail/detail.component';
import { UpdateComponent } from './update/update.component';



@NgModule({
  declarations: [
    CreateComponent,
    ListComponent,
    DetailComponent,
    UpdateComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ContactModule { }
