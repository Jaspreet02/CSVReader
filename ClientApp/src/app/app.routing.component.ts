import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VehicleSaleDataComponent } from './vehicle-sale-data/vehicle-sale-data.component';

const routes: Routes = [
  { path: '', component: VehicleSaleDataComponent, pathMatch: 'full' },
    { path: 'vehiclesale', component: VehicleSaleDataComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class RoutingModule { }
