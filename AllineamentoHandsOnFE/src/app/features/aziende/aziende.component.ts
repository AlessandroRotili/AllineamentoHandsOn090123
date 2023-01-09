import { Component, OnInit } from '@angular/core';
import { CompanyService } from 'src/app/core/services/comp-ervice';
import { Company } from 'src/app/shared/models/company-models/company';

@Component({
  selector: 'app-aziende',
  templateUrl: './aziende.component.html',
  styleUrls: ['./aziende.component.scss']
})
export class AziendeComponent implements OnInit {

  constructor(private service: CompanyService) { }
  ngOnInit(): void {
    this.service.getAll().then(aziende => {
      this.companies = aziende
      console.log(this.companies)
    })
  }

  displayedColumns: string[] = ['id', 'name', 'description', ''];
  companies: Company[] = [];

}
