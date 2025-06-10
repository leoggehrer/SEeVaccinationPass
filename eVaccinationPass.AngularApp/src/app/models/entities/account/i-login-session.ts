//@GeneratedCode
import { IVersionModel } from '@app-models/i-version-model';
//@CustomImportBegin
//@CustomImportEnd
export interface ILoginSession extends IVersionModel {
  identityId: number;
  timeOutInMinutes: number;
  sessionToken: string;
  loginTime: Date;
  lastAccess: Date;
  logoutTime: Date;
  optionalInfo: string;
  name: string;
  email: string;
 isActive: boolean;
 isTimeout: boolean;
  roles: IRole[];
  id: number;
//@CustomCodeBegin
//@CustomCodeEnd
}
