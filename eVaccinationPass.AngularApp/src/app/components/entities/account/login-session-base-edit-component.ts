//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GenericEditComponent } from '@app/components/base/generic-edit.component';
import { ILoginSession } from '@app-models/entities/account/i-login-session';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class LoginSessionBaseEditComponent extends GenericEditComponent<ILoginSession> implements OnInit {
  constructor(public override activeModal: NgbActiveModal)
  {
    super(activeModal);
  }
  ngOnInit(): void {
  }
  public override get title(): string {
    return 'LoginSession' + super.title;
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
