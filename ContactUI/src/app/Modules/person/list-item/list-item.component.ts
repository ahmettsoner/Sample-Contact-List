import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { Person } from 'src/app/Models/Person';
import { PersonService } from 'src/app/Services/person.service';

@Component({
  selector: 'app-list-item',
  templateUrl: './list-item.component.html',
  styleUrls: ['./list-item.component.css']
})
export class ListItemComponent implements OnInit {
  @Input() person!:Person;
  @Output() deletePerson:EventEmitter<Person> = new EventEmitter()

  constructor(private personService:PersonService) { }

  ngOnInit(): void {
  }

  onDelete(person:Person){
    this.deletePerson.emit(person);
  }

}
