//@GeneratedCode
import { IVersionModel } from '@app-models/i-version-model';
import { State } from '@app-enums/enums/state';
//@CustomImportBegin
//@CustomImportEnd
export interface IIdentity extends IVersionModel {
  name: string;
  email: string;
  timeOutInMinutes: number;
  accessFailedCount: number;
  state:   State;
  identityxRoles: IIdentityXRole[];
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}
