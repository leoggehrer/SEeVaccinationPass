//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IUser } from '@app-models/entities/account/i-user';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class UserService extends ApiEntityBaseService<IUser> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/users');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
