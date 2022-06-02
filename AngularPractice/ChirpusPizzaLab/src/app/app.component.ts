import { Component } from '@angular/core';
import { MenuItem } from './menu-item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'practice';

  menuItemArray:Array<MenuItem> = [
    {name:'Chicken Fingers',price:11.99,category:'dinner'},
    {name:'Piza',category:'dinner',price:11.99},
    {name:'wings',category:'sides',price:8.99},
    {name:'Breadsticks',category:'sides',price:4.99},
    {name:'Ceasar Salad',category:'sides',price:5.99},
    {name:'Cinnamon Roll',category:'dessert',price:8.99}
  ];

 //menuItem:MenuItem = {name:'burger', category:'dinner', price:10};
 
}
