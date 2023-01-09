import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AziendeComponent } from './aziende.component';

const routes: Routes = [
  {path: '', component: AziendeComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AziendeRoutingModule { }
