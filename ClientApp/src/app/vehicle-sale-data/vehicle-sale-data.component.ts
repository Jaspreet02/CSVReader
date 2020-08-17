import { Component } from '@angular/core';
import { VehicleSale } from '../shared/vehiclesale';
import { VehicleSaleService } from '../services/vehiclesale.service';
import { PagedResponse } from '../shared/PagedResponse';

@Component({
  selector: 'app-vehicle-sale-data',
  templateUrl: './vehicle-sale-data.component.html',
  styleUrls: ['./vehicle-sale-data.component.css']
})
export class VehicleSaleDataComponent {
  response: PagedResponse<VehicleSale>[];

  constructor(private service: VehicleSaleService) {
  }

  ngOnInit(){
   this.getVehicleSalesDetail();
  }

  getVehicleSalesDetail(): void {
    this.service.getVehicleSalesDetail().subscribe(result => {
      this.response = result
    }, error => console.error(error));    
  }

}
