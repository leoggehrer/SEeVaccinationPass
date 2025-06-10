//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IIdentityXRole } from '@app-models/entities/account/i-identity-x-role';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class IdentityXRoleService extends ApiEntityBaseService<IIdentityXRole> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/identityxroles');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
