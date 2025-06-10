//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GenericEditComponent } from '@app/components/base/generic-edit.component';
import { IRole } from '@app-models/entities/account/i-role';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class RoleBaseEditComponent extends GenericEditComponent<IRole> implements OnInit {
  constructor(public override activeModal: NgbActiveModal)
  {
    super(activeModal);
  }
  ngOnInit(): void {
  }
  public override get title(): string {
    return 'Role' + super.title;
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
