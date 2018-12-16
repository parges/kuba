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
    this.addPatient(this.patientForm.value);
    alert('Thanks!');
  }

  addPatient (patient: Patient): void {
    this.patientService.addPatient(patient)
      .subscribe(function() {
        alert('received');
      });
  }
}
