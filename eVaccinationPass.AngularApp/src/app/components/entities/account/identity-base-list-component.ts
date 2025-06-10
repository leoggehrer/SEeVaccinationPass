//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessageBoxService } from '@app/services/message-box-service.service';
import { GenericEntityListComponent } from '@app/components/base/generic-entity-list.component';
import { IIdentity } from '@app-models/entities/account/i-identity';
import { IdentityService } from '@app-services/http/entities/account/identity-service';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class IdentityBaseListComponent extends GenericEntityListComponent<IIdentity> implements OnInit {
  constructor(
              protected override modal: NgbModal,
              protected dataAccessService: IdentityService,
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
