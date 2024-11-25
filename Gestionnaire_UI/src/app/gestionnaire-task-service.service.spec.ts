import { TestBed } from '@angular/core/testing';

import { GestionnaireTaskServiceService } from './gestionnaire-task-service.service';

describe('GestionnaireTaskServiceService', () => {
  let service: GestionnaireTaskServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GestionnaireTaskServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
