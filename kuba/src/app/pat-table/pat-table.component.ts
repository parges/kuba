import { IPatient } from './../patient';
import { Component, OnInit } from '@angular/core';
import {animate, state, style, transition, trigger} from '@angular/animations';
import { PatientServiceService } from '../services/patient-service.service';


@Component({
  selector: 'app-pat-table',
  templateUrl: './pat-table.component.html',
  styleUrls: ['./pat-table.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0', display: 'none'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ]
})
export class PatTableComponent implements OnInit {

  dataSource;
  columnsToDisplay = ['Vorname', 'Nachname', 'Alter', 'Adresse', 'Beschreibung'];
  entityColumns = ['firstname', 'lastname', 'age', 'address', 'description'];
  expandedElement: IPatient;

  constructor(private patientService: PatientServiceService) { }

  ngOnInit() {
    this.getPatients();
  }

  /**
   * returns an observable List of Patients from the Service
   */
  getPatients(): void {
    this.patientService.getPatients()
      .subscribe(patients => this.dataSource = patients);
  }

}




