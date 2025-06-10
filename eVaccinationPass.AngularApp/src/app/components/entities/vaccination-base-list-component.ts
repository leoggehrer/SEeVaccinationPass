//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessageBoxService } from '@app/services/message-box-service.service';
import { GenericEntityListComponent } from '@app/components/base/generic-entity-list.component';
import { IVaccination } from '@app-models/entities/i-vaccination';
import { VaccinationService } from '@app-services/http/entities/vaccination-service';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class VaccinationBaseListComponent extends GenericEntityListComponent<IVaccination> implements OnInit {
  constructor(
              protected override modal: NgbModal,
              protected dataAccessService: VaccinationService,
              protected override  messageBoxService: MessageBoxService)
  {
    super(modal, dataAccessService, messageBoxService);
  }
  ngOnInit(): void {
    this.reloadData();
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
