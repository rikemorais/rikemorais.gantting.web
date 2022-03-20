import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AssignmentsComponent } from './assignments/assignments.component';
import { AssigneesComponent } from './assignees/assignees.component';
@NgModule({
  declarations: [		
    AppComponent,
    AssignmentsComponent,
    AssigneesComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
