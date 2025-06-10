//@GeneratedCode
import { Directive, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { GenericEditComponent } from '@app/components/base/generic-edit.component';
import { IVaccination } from '@app-models/entities/i-vaccination';
//@CustomImportBegin
//@CustomImportEnd
@Directive()
export abstract class VaccinationBaseEditComponent extends GenericEditComponent<IVaccination> implements OnInit {
  constructor(public override activeModal: NgbActiveModal)
  {
    super(activeModal);
  }
  ngOnInit(): void {
  }
  public override get title(): string {
    return 'Vaccination' + super.title;
  }
//@CustomCodeBegin
//@CustomCodeEnd
}
