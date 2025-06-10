//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessageBoxService } from '@app/services/message-box-service.service';
import { GenericEntityListComponent } from '@app/components/base/generic-entity-list.component';
import { ILoginSession } from '@app-models/entities/account/i-login-session';
import { LoginSessionService } from '@app-services/http/entities/account/login-session-service';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class LoginSessionBaseListComponent extends GenericEntityListComponent<ILoginSession> implements OnInit {
  constructor(
              protected override modal: NgbModal,
              protected dataAccessService: LoginSessionService,
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
