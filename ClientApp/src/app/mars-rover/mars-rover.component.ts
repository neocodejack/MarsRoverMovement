import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-mars-rover',
  templateUrl: './mars-rover.component.html',
})
export class MarsRoverComponent {
    public _httpClient: HttpClient;
    public _left: number;
    public _right: number;
    public _top: number;
    public moves: Moves[];

    constructor(httpClient:HttpClient){
        this._httpClient = httpClient;
    }

    public AddMoves(){
        this.moves.push({Left:this._left, Right:this._right, Top:this._top});
    }

    public SaveMoves(){
        const httpOptions = {
            headers: new HttpHeaders({
              'Content-Type': 'application/json'
            })
        };

        this._httpClient.post('./api/data/addmoves', JSON.stringify(this.moves), httpOptions).subscribe(data => {
            console.log(data);
        }, error => {
        console.log(JSON.stringify(error));
        });
    }
}

interface Moves{
    Left: number;
    Right: number;
    Top: number;
}