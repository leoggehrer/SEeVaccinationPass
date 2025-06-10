//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { ILoginSession } from '@app-models/entities/account/i-login-session';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class LoginSessionService extends ApiEntityBaseService<ILoginSession> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/loginsessions');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
