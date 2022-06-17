import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GetallfilmComponent } from './getallfilm.component';

describe('GetallfilmComponent', () => {
  let component: GetallfilmComponent;
  let fixture: ComponentFixture<GetallfilmComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GetallfilmComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GetallfilmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
