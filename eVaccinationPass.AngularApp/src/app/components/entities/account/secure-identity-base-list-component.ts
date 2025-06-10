//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessageBoxService } from '@app/services/message-box-service.service';
import { GenericEntityListComponent } from '@app/components/base/generic-entity-list.component';
import { ISecureIdentity } from '@app-models/entities/account/i-secure-identity';
import { SecureIdentityService } from '@app-services/http/entities/account/secure-identity-service';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class SecureIdentityBaseListComponent extends GenericEntityListComponent<ISecureIdentity> implements OnInit {
  constructor(
              protected override modal: NgbModal,
              protected dataAccessService: SecureIdentityService,
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
