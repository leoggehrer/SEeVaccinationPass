//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { ISecureIdentity } from '@app-models/entities/account/i-secure-identity';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class SecureIdentityService extends ApiEntityBaseService<ISecureIdentity> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/secureidentities');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
