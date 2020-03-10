import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SecurityScreeningRequirementsComponent } from './security-screening-requirements.component';
import { MatSnackBar } from '@angular/material';
import { LegalEntityDataService } from '@services/legal-entity-data.service';
import { of } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { ActivatedRouteStub } from '@app/testing/activated-route-stub';
import { ApplicationDataService } from '@services/application-data.service';
import { LicenseDataService } from '@services/license-data.service';
import { PaymentDataService } from '@services/payment-data.service';

describe('SecurityScreeningRequirementsComponent', () => {
  let component: SecurityScreeningRequirementsComponent;
  let fixture: ComponentFixture<SecurityScreeningRequirementsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [SecurityScreeningRequirementsComponent],
      providers: [
        { provide: MatSnackBar, useValue: {} },
        { provide: ActivatedRoute, useValue: new ActivatedRouteStub() },
        { provide: PaymentDataService, useValue: {} },
        { provide: LegalEntityDataService, useValue: { getCurrentSecurityScreeningItems: () => of({})} },
        { provide: LicenseDataService, useValue: { getAllCurrentLicenses: () => of([])} },
        { provide: ApplicationDataService, useValue: { getApplicationById: () => of({})} }
      ]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SecurityScreeningRequirementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
