import { TestBed } from '@angular/core/testing';

import { JobService } from './job.service';
import { HttpClientModule } from '@angular/common/http';

describe('JobService', () => {
  beforeEach(() => TestBed.configureTestingModule({imports: [
    HttpClientModule,
  ],}));

  it('should be created', () => {
    const service: JobService = TestBed.get(JobService);
    expect(service).toBeTruthy();
  });
});
