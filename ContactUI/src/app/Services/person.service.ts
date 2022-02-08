import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Person } from '../Models/Person';

const httpOptions={
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})


export class PersonService {
  serviceUrl:string = 'https://localhost:5001/api/person';

  constructor(private http:HttpClient) { }

  listPersons():Observable<Person[]>{
    const url = `${this.serviceUrl}`;

    return this.http.get<Person[]>(url, httpOptions);
  }

  getPersons(code:string):Observable<Person[]>{
    const url = `${this.serviceUrl}/{code}`;

    return this.http.get<Person[]>(url, httpOptions);
  }

  addPersons(person:Person):Observable<Person>{
    const url = `${this.serviceUrl}`;

    return this.http.post<Person>(url, person, httpOptions);
  }

  updatePersons(person:Person):Observable<Person>{
    const url = `${this.serviceUrl}/{person.code}`;

    return this.http.put<Person>(url, person, httpOptions);
  }

  deletePersons(person:Person){
    const url = `${this.serviceUrl}/{person.code}`;

    this.http.delete(url, httpOptions);
  }
}
