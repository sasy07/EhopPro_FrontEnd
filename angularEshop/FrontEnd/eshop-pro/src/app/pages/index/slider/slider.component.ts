import {Component, OnInit} from '@angular/core';
import {SliderService} from '../../../services/slider.service';
import {BehaviorSubject} from 'rxjs';
import {Slider} from '../../../DTOs/Sliders/Slider';


declare function homeSlider(): any;

@Component({
  selector: 'app-index-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.scss']
})
export class SliderComponent implements OnInit {

  public sliders: Slider[] = [];

  constructor(
    private sliderService: SliderService
  ) {
  }

  ngOnInit(): void {

    this.sliderService.getCurrentSliders().subscribe(sliders => {
      if (sliders === null) {
        this.sliderService.GetSliders().subscribe(res => {
          if (res.status === 'Success') {
            this.sliderService.setCurrentSliders(res.data);
          }
        });
      } else {
        this.sliders = sliders;
        setInterval(() => {
          homeSlider();
        }, 100);
      }
    });
  }
}

