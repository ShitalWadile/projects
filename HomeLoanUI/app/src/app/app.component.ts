import { Component , OnInit} from '@angular/core';
import { from, Observable, observable, observeOn } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';
myObservable=new Observable((observer)=>{
  console.log('Observable starts')
})

ngOnInit(): void {
  this.myObservable.subscribe((val)=>{
    console.log(val);
  })
}


}
