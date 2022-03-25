import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assignments',
  templateUrl: './assignments.component.html',
  styleUrls: ['./assignments.component.scss']
})
export class AssignmentsComponent implements OnInit {

  public assignments: any = [];
  public assignmentsFiltered: any = [];

  widthImg: number = 50;
  marginImg: number = 2;
  showImage: boolean = true;
  private _filterList: string = '';

  public get filterList() {
    return this._filterList;
  }

  public set filterList(value: string) {
    this._filterList = value;
    this.assignmentsFiltered = this.filterList ? this.filterAssignments(this.filterList) : this.assignments;
  }

  filterAssignments(filterBy: string): any {
    filterBy = filterBy.toLocaleLowerCase();
    return this.assignments.filter(
      (assignment: { name: string; description: string;}) => assignment.name.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
      assignment.description.toLocaleLowerCase().indexOf(filterBy) !== -1
      );
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getAssignments();
  }

  alterImage(): void {
    this.showImage = !this.showImage;
  }

  public getAssignments(): void {
    this.http.get('https://localhost:5001/api/assignments').subscribe(
      response => {
        this.assignments = response;
        this.assignmentsFiltered = this.assignments;
      },
      error => console.log(error)
    );
  }
}
