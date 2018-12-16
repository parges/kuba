import { PATIENTS } from './mock-patients';
import { Patient } from '../patient';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { HttpClient } from '@angular/common/http';

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
}


