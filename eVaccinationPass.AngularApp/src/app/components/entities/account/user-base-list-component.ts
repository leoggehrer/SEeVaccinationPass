//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessageBoxService } from '@app/services/message-box-service.service';
import { GenericEntityListComponent } from '@app/components/base/generic-entity-list.component';
import { IUser } from '@app-models/entities/account/i-user';
import { UserService } from '@app-services/http/entities/account/user-service';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class UserBaseListComponent extends GenericEntityListComponent<IUser> implements OnInit {
  constructor(
              protected override modal: NgbModal,
              protected dataAccessService: UserService,
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
