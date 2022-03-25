import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assignments',
  templateUrl: './assignments.component.html',
  styleUrls: ['./assignments.component.scss']
})
export class AssignmentsComponent implements OnInit {

  public assignments: any = [];
  widthImg: number = 50;
  marginImg: number = 2;
  showImage: boolean = true;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getAssignments();
  }

  alterImage(): void {
    this.showImage = !this.showImage;
  }

  public getAssignments(): void {
    this.http.get('https://localhost:5001/api/assignments').subscribe(
      response => this.assignments = response,
      error => console.log(error)
    );
  }
}
