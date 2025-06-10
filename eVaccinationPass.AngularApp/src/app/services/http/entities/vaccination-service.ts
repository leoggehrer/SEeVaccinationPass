//@GeneratedCode
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ApiEntityBaseService } from '@app-services/api-entity-base.service';
import { environment } from '@environment/environment';
import { IVaccination } from '@app-models/entities/i-vaccination';
//@CustomImportBegin
//@CustomImportEnd
@Injectable({
  providedIn: 'root',
})
export class VaccinationService extends ApiEntityBaseService<IVaccination> {
  constructor(public override http: HttpClient) {
    super(http, environment.API_BASE_URL + '/vaccinations');
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
