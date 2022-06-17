import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletefilmbytitleComponent } from './deletefilmbytitle.component';

describe('DeletefilmComponent', () => {
  let component: DeletefilmbytitleComponent;
  let fixture: ComponentFixture<DeletefilmbytitleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeletefilmbytitleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeletefilmbytitleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
