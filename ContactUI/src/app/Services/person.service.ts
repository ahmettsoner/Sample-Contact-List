import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Person } from '../Models/Person';

const httpOptions={
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({providedIn: 'root'})
export class PersonService {
  serviceUrl:string = 'https://localhost:44395/api/Person';

  constructor(private http:HttpClient) { }

  listPersons():Observable<Person[]>{
    const url = `${this.serviceUrl}`;

    return this.http.get<Person[]>(url, httpOptions);
  }

  getPerson(code:string):Observable<Person[]>{
    const url = `${this.serviceUrl}/{code}`;

    return this.http.get<Person[]>(url, httpOptions);
  }

  addPerson(person:Person):Observable<Person>{
    const url = `${this.serviceUrl}`;

    return this.http.post<Person>(url, person, httpOptions);
  }

  updatePerson(person:Person):Observable<Person>{
    const url = `${this.serviceUrl}/{person.code}`;

    return this.http.put<Person>(url, person, httpOptions);
  }

  deletePerson(person:Person){
    const url = `${this.serviceUrl}/{person.code}`;

    this.http.delete(url, httpOptions);
  }
}
