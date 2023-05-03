import { Injectable } from '@angular/core';
@Injectable({ providedIn: 'root' })
export class Constants {
  public readonly API_ENDPOINT: string = 'https://localhost:7283/';
  public readonly API_MOCK_ENDPOINT: string = 'mock-domain/api';
}
