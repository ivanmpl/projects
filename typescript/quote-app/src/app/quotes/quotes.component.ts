import { Injectable } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { Quote } from '../quote'
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-quotes',
  templateUrl: './quotes.component.html',
  styleUrls: ['./quotes.component.css']
})

@Injectable()
export class QuotesComponent implements OnInit {

  private quotesUrl = 'https://localhost:5001/api/Quote';  // URL to web api

  private quotes = [];

  getQuotes() {
    return this.http.get(this.quotesUrl);
  }

  listQuotes() {
    this.getQuotes()
    .subscribe(

      data => {
        console.log(data)
      },

      error => {
        console.log(error)
      },
      
      () => {
        console.log("Request complete")
      }
    )
  }


  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.listQuotes();
  }

}


