//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GenericEditComponent } from '@app/components/base/generic-edit.component';
import { ISecureIdentity } from '@app-models/entities/account/i-secure-identity';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class SecureIdentityBaseEditComponent extends GenericEditComponent<ISecureIdentity> implements OnInit {
  constructor(public override activeModal: NgbActiveModal)
  {
    super(activeModal);
  }
  ngOnInit(): void {
  }
  public override get title(): string {
    return 'SecureIdentity' + super.title;
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
