//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GenericEditComponent } from '@app/components/base/generic-edit.component';
import { IUser } from '@app-models/entities/account/i-user';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class UserBaseEditComponent extends GenericEditComponent<IUser> implements OnInit {
  constructor(public override activeModal: NgbActiveModal)
  {
    super(activeModal);
  }
  ngOnInit(): void {
  }
  public override get title(): string {
    return 'User' + super.title;
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
