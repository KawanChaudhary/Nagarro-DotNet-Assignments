import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetAllResultComponent } from './get-all-result.component';

describe('GetAllResultComponent', () => {
  let component: GetAllResultComponent;
  let fixture: ComponentFixture<GetAllResultComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GetAllResultComponent]
    });
    fixture = TestBed.createComponent(GetAllResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
