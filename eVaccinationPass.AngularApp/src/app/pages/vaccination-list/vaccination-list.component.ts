import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { VaccinationBaseListComponent } from '@app/components/entities/vaccination-base-list-component';
import { VaccinationEditComponent } from '@app-components/vaccination-edit/vaccination-edit.component';

@Component({
  selector: 'app-vaccination-list',
  imports: [ CommonModule, FormsModule ],
  templateUrl: './vaccination-list.component.html',
  styleUrl: './vaccination-list.component.css'
})
export class VaccinationListComponent extends VaccinationBaseListComponent {

    override ngOnInit() {
        this._queryParams.filter = 'firstName.ToLower().Contains(@0) OR lastName.ToLower().Contains(@0) OR doctor.ToLower().Contains(@0) OR vaccine.ToLower().Contains(@0)';
        this.reloadData();
    }

    override getEditComponent() {
        return VaccinationEditComponent;
    }
}
