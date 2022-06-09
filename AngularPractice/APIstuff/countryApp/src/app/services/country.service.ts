import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Country } from '../interfaces/country';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  constructor(private client:HttpClient) { }

  getCountryByName(name:string) : Observable<Country>{
    let endpoint = "https://restcountries.com/v3.1/name/" + name;
    let response = this.client.get<Country>(endpoint);

    return response;
  }
}
