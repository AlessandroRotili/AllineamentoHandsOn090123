import { Component, OnInit } from '@angular/core';
import { Ad } from 'src/app/shared/models/ad-models/ad.model';
import { AdService } from '../services/ad-service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(private adService: AdService) { }
  dataSource: any
  adToShow: Ad = {
    id: -1,
    title: '',
    description: '',
    ral: 0,
    senority: 0
  }
  currentIndex: number = 0;


  async ngOnInit(): Promise<void> {
    await this.adService.getAll()
      .then(ads => {
        this.dataSource = ads
        this.adToShow = ads[this.currentIndex]
        console.log(this.dataSource)
      })
      .catch(err => console.log(err))
  }


  nextIndex() {
    this.currentIndex++;
  }
  previousIndex() {
    this.currentIndex--;
  }

}
