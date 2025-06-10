//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IRole } from '@app-models/entities/account/i-role';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class RoleService extends ApiEntityBaseService<IRole> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/roles');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
