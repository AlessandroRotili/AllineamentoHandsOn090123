import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AziendeRoutingModule } from './aziende-routing.module';
import { AziendeComponent } from './aziende.component';


@NgModule({
  declarations: [
    AziendeComponent
  ],
  imports: [
    CommonModule,
    AziendeRoutingModule
  ]
})
export class AziendeModule { }
