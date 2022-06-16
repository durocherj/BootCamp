import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Pet } from 'src/app/interfaces/pet';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-pet-details',
  templateUrl: './pet-details.component.html',
  styleUrls: ['./pet-details.component.css']
})
export class PetDetailsComponent implements OnInit {

  constructor(private route:ActivatedRoute, private service:ApiService) { }

  pet:Pet | undefined;
  id:number = 0;

  ngOnInit(): void {
    this.route.params.subscribe(params => this.getPetById(params['id']));
  }


  getPetById(id:number){
    this.service.getPetById(id).subscribe((data:Pet) => this.pet = data);    
  }

}
