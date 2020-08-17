import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { VehicleSale } from 'src/app/shared/vehiclesale';
import { Observable } from 'rxjs';
import { PagedResponse } from '../shared/PagedResponse';

@Injectable({
  providedIn: 'root'
})

export class VehicleSaleService {

    
  private Url ;  // URL to web api

  constructor( private http: HttpClient,@Inject('BASE_URL') baseUrl: string) { this.Url = baseUrl}

  getVehicleSalesDetail(): Observable<PagedResponse<VehicleSale>[]> {
    return this.http.get<PagedResponse<VehicleSale>[]>(this.Url + 'api/vehiclesale');
  }
}
