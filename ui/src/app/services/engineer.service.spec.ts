import { TestBed } from '@angular/core/testing';

import { EngineerService } from './engineer.service';
import { HttpClientModule } from '@angular/common/http';

describe('EngineerService', () => {
  beforeEach(() => TestBed.configureTestingModule({imports: [
    HttpClientModule,
  ], }));

  it('should be created', () => {
    const service: EngineerService = TestBed.get(EngineerService);
    expect(service).toBeTruthy();
  });
});
