import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PatTableComponent } from './pat-table.component';

describe('PatTableComponent', () => {
  let component: PatTableComponent;
  let fixture: ComponentFixture<PatTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PatTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PatTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
