import { BrowserModule } from '@angular/platform-browser';
import { NgModule, ɵINJECTOR_IMPL__POST_R3__ } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RoutingModule } from './app.routing.component';

import { AppComponent } from './app.component';
import { VehicleSaleDataComponent } from './vehicle-sale-data/vehicle-sale-data.component';
import { VehicleSaleService } from './services/vehiclesale.service';

@NgModule({
  declarations: [
    AppComponent,
    VehicleSaleDataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RoutingModule
  ],
  providers: [VehicleSaleService],
  bootstrap: [AppComponent]
})
export class AppModule { }
