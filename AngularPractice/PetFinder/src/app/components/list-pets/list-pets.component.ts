import { Component, OnInit } from '@angular/core';
import { Pet } from 'src/app/interfaces/pet';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-list-pets',
  templateUrl: './list-pets.component.html',
  styleUrls: ['./list-pets.component.css']
})
export class ListPetsComponent implements OnInit {

  constructor(private service:ApiService) { }

  petArray:Pet[] = [];

  //this functions runs when your component loads
  ngOnInit(): void {
    this.getAllPets();
  }

  getAllPets(){
    this.service.getAllPets().subscribe((data:Pet[]) => this.petArray = data);
  }

}
