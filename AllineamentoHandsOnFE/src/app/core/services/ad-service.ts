import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Endpoint } from '../endpoints';
import { Ad } from 'src/app/shared/models/ad-models/ad.model';
import { lastValueFrom } from 'rxjs';


@Injectable({
    providedIn: 'root'
})
export class AdService {

    constructor(private client: HttpClient) {

     }

     getAll(): Promise<Ad[]> {
        return lastValueFrom(this.client.get<Ad[]>(Endpoint.Ad));
    }


}