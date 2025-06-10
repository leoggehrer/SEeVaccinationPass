//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessageBoxService } from '@app/services/message-box-service.service';
import { GenericEntityListComponent } from '@app/components/base/generic-entity-list.component';
import { IIdentityXRole } from '@app-models/entities/account/i-identity-x-role';
import { IdentityXRoleService } from '@app-services/http/entities/account/identity-x-role-service';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class IdentityXRoleBaseListComponent extends GenericEntityListComponent<IIdentityXRole> implements OnInit {
  constructor(
              protected override modal: NgbModal,
              protected dataAccessService: IdentityXRoleService,
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
