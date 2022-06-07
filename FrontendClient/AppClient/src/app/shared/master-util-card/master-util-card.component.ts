import { Component, Input, OnInit } from '@angular/core';
import { MasterUtilityGetModel } from 'src/app/core/interfaces/models/utilities/master-utility-get-model';

@Component({
  selector: 'app-master-util-card',
  templateUrl: './master-util-card.component.html',
  styleUrls: ['./master-util-card.component.css']
})
export class MasterUtilCardComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() cardData: MasterUtilityGetModel;

}
