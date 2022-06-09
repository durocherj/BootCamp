import { Component, OnInit } from '@angular/core';
import { Country } from '../interfaces/country';
import { CountryService } from '../services/country.service';

@Component({
  selector: 'app-country-detail',
  templateUrl: './country-detail.component.html',
  styleUrls: ['./country-detail.component.css']
})
export class CountryDetailComponent implements OnInit {

  constructor(private service:CountryService) { }

  countryArray:Country[] = [];

  ngOnInit(): void {
  }

  getCountryByName(form:any){
    this.service.getCountryByName(form.value["countryName"])
    .subscribe(x => console.log(x));
  }

}
