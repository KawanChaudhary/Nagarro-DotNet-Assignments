import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FindresultComponent } from './findresult.component';

describe('FindresultComponent', () => {
  let component: FindresultComponent;
  let fixture: ComponentFixture<FindresultComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FindresultComponent]
    });
    fixture = TestBed.createComponent(FindresultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
