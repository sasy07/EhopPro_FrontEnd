import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {BehaviorSubject, Observable} from 'rxjs';
import {HomeSliderResponse} from '../DTOs/Sliders/HomeSliderResponse';
import {Slider} from '../DTOs/Sliders/Slider';

@Injectable({
  providedIn: 'root'
})
export class SliderService {
  // @ts-ignore
  private homeSliders: BehaviorSubject<Slider[]> = new BehaviorSubject<Slider[]>(null);

  constructor(
    private http: HttpClient
  ) {
  }

  public GetSliders(): Observable<HomeSliderResponse> {
    return this.http.get<HomeSliderResponse>('https://localhost:5001/api/slider/GetActiveSliders');
  }

  public getCurrentSliders(): Observable<Slider[]> {
    return this.homeSliders;
  }

  // tslint:disable-next-line:typedef
  public setCurrentSliders(sliders: Slider[]) {
    this.homeSliders.next(sliders);
  }
}
