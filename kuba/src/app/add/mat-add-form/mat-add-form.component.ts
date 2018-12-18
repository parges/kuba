import { AddComponent } from './../add.component';
import { Patient } from './../../patient';
import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { PatientServiceService } from 'src/app/services/patient-service.service';

@Component({
  selector: 'app-mat-add-form',
  templateUrl: './mat-add-form.component.html',
  styleUrls: ['./mat-add-form.component.scss'],
})
export class MatAddFormComponent {
  patientForm = this.fb.group({
    firstName: [null, Validators.required],
    lastName: [null, Validators.required],
    address: [null, Validators.required],
    city: [null, Validators.required],
    postalCode: [null, Validators.compose([
      Validators.required, Validators.minLength(5), Validators.maxLength(5)])
    ],
    telefone: [null],
    email: [null],
    description: [null]
  });

  constructor(private fb: FormBuilder, private patientService: PatientServiceService) {}

  onSubmit() {
    let patient = this.convertFormToObject(this.patientForm.value);
    this.addPatient(patient);
    alert('Thanks!');
  }

  addPatient (patient: Patient): void {
    this.patientService.addPatient(patient)
      .subscribe(function() {
        alert('received');
      });
  }

  convertFormToObject (_obj: any): Patient {
    let patient = new Patient();
    patient.Firstname = _obj.firstName;
    patient.Lastname = _obj.lastName;
    patient.Age = _obj.age = 1;
    patient.Address = _obj.address;
    patient.Description = _obj.description = 'Bla';

    return patient;
  }
}
