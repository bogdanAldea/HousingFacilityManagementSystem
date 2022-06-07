import { Component, Input, OnInit } from '@angular/core';
import { InfoCard } from 'src/app/core/interfaces/cards/info-card';

@Component({
  selector: 'app-info-card',
  templateUrl: './info-card.component.html',
  styleUrls: ['./info-card.component.css']
})
export class InfoCardComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Input() cardData: InfoCard;
}
