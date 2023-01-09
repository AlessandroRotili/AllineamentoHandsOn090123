import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { lastValueFrom } from 'rxjs';
import { Company } from 'src/app/shared/models/company-models/company';
import { Endpoint } from '../endpoints';

@Injectable({
    providedIn: 'root'
})
export class CompanyService {
    constructor(private cient: HttpClient) { }

    getAll() : Promise<Company[]> {
        return lastValueFrom(this.cient.get<Company[]>(Endpoint.company));

    }
}