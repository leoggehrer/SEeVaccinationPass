//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GenericEditComponent } from '@app/components/base/generic-edit.component';
import { IIdentityXRole } from '@app-models/entities/account/i-identity-x-role';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class IdentityXRoleBaseEditComponent extends GenericEditComponent<IIdentityXRole> implements OnInit {
  constructor(public override activeModal: NgbActiveModal)
  {
    super(activeModal);
  }
  ngOnInit(): void {
  }
  public override get title(): string {
    return 'IdentityXRole' + super.title;
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
