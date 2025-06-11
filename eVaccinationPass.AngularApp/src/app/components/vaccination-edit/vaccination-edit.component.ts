import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { VaccinationBaseEditComponent } from '@app-components/entities/vaccination-base-edit-component';
import { IVaccination } from '@app/models/entities/i-vaccination';

@Component({
  selector: 'app-vaccination-edit',
  imports: [ CommonModule, FormsModule],
  templateUrl: './vaccination-edit.component.html',
  styleUrl: './vaccination-edit.component.css'
})
export class VaccinationEditComponent extends VaccinationBaseEditComponent {

  public get getDate(): string {
    return this.dataItem.date ? new Date(this.dataItem.date).toISOString().split('T')[0] : '';
  }
  override ngOnInit(): void {
    // Formatieren, damit das Datum im HTML-Formular angezeigt wird
  }
  protected override dataItemChanged(dataItem: IVaccination): void {
    dataItem.date = this.formatDateToInput(new Date(dataItem.date));
  }
  formatDateToInput(date: Date): string {
    return date.toISOString().split('T')[0]; // "2025-06-11"
  }
}
