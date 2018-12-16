import { Patient } from './../patient';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})

export class PatientServiceService {

  private patientUrl = 'https://localhost:44370/api/patient';

  constructor(
    private http: HttpClient
  ) { }

  getPatients(): Observable<Patient[]> {
    return this.http.get<Patient[]>(this.patientUrl);
  }

  addPatient(patient: Patient): Observable<Patient> {
    return this.http.post<Patient>(this.patientUrl, patient, httpOptions);
  }
}


