import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditresultComponent } from './editresult.component';

describe('EditresultComponent', () => {
  let component: EditresultComponent;
  let fixture: ComponentFixture<EditresultComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EditresultComponent]
    });
    fixture = TestBed.createComponent(EditresultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
