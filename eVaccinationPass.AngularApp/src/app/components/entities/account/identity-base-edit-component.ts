//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GenericEditComponent } from '@app/components/base/generic-edit.component';
import { IIdentity } from '@app-models/entities/account/i-identity';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class IdentityBaseEditComponent extends GenericEditComponent<IIdentity> implements OnInit {
  constructor(public override activeModal: NgbActiveModal)
  {
    super(activeModal);
  }
  ngOnInit(): void {
  }
  public override get title(): string {
    return 'Identity' + super.title;
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
