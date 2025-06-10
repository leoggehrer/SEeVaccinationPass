//@GeneratedCode
import { IKeyModel } from '@app-models/i-key-model';
//@CustomImportBegin
//@CustomImportEnd
export interface IVaccination extends IKeyModel {
  date: Date;
  vaccine: string;
  socialNumber: string;
  firstName: string;
  lastName: string;
  doctor: string;
  note: string;
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}
