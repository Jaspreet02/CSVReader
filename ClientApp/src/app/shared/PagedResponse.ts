import { VehicleSale } from "./vehiclesale";

export interface PagedResponse<T> {
    Vehicle: string;
    Count: number;
    Result: T[];
  }
