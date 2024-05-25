import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { endpoints } from '../utils/enpoints';

@Injectable({
  providedIn: 'root'
})
export class GruposService {
  private readonly http = inject(HttpClient);
  
  constructor() { }

  obtenerGrupo() : Observable<any>{
    return this.http.get(endpoints.obtenerGrupo);
  }
}
