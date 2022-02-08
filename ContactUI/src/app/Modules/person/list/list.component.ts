import { Component, OnInit } from '@angular/core';
import { Person } from 'src/app/Models/Person';
import { PersonService } from 'src/app/Services/person.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {
  persons!: Person[];

  constructor(private personService: PersonService) { }

  ngOnInit(): void {
    this.listPersons();
  }

  listPersons(){
    this.personService.listPersons().subscribe(data => {
      this.persons = data;
    });
  }

  deletePerson(person:Person){
    this.persons = this.persons.filter(t=>t.code != person.code);

    this.personService.deletePerson(person);
  }

}
