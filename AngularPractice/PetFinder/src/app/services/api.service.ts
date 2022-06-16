import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Pet } from '../interfaces/pet';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private client:HttpClient) { }

  //Get all pets
  getAllPets() : Observable<Pet[]>{
    let pets = this.client.get<Pet[]>(environment.apiUrl + "Pet");

    return pets;
  }

  //Get a pet by its id
  getPetById(id:number) : Observable<Pet>{
    let pet = this.client.get<Pet>(environment.apiUrl + "Pet/GetPetById?id=" + id);

    return pet;
  }

  //Get a pet by its name
  getPetByName(name:string) : Observable<Pet>{
    let pet = this.client.get<Pet>(environment.apiUrl + "Pet/GetPetByName/" + name);

    return pet;
  }

  //adopt a pet by id
  adoptAPetById(id:number){
    let result = this.client.post(environment.apiUrl + "AdoptPetById", id);

    return result;
  }
}
