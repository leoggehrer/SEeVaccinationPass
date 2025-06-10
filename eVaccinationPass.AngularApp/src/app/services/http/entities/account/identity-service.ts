//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IIdentity } from '@app-models/entities/account/i-identity';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class IdentityService extends ApiEntityBaseService<IIdentity> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/identities');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
