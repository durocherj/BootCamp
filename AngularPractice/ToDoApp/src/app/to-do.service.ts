import { Injectable } from '@angular/core';
import { Todo } from './todo';

@Injectable({
  providedIn: 'root'
})
export class ToDoService {

  constructor() { }

  getToDoItems() :Array<Todo>{
    return [
      { task:'Sweeping the floor', completed:false},
      {task:'Wash the dishes', completed:false},
      {task:'Clean cat box', completed:false}
    ]
  }
}
