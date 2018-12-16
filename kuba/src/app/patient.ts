export class Patient {
    Firstname: string;
    Lastname: string;
    Age: number;
    Address: string;
    Description: string;
    /*tel: string;
  summary_quest: number;
  summary_test: number;
  */
}

export interface IPatient {
    Firstname: string;
    Lastname: string;
    Age: number;
    Address: string;
    Description: string;
}
