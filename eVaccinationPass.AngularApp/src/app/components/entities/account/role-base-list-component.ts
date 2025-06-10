//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessageBoxService } from '@app/services/message-box-service.service';
import { GenericEntityListComponent } from '@app/components/base/generic-entity-list.component';
import { IRole } from '@app-models/entities/account/i-role';
import { RoleService } from '@app-services/http/entities/account/role-service';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class RoleBaseListComponent extends GenericEntityListComponent<IRole> implements OnInit {
  constructor(
              protected override modal: NgbModal,
              protected dataAccessService: RoleService,
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
