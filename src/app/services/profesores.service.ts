import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { endpoints } from '../utils/enpoints';

@Injectable({
  providedIn: 'root'
})
export class ProfesoresService {
  private readonly http = inject(HttpClient);

  constructor() { }

  obtenerProfesor() : Observable<any>{
    return this.http.get(endpoints.obtenerGrupo);
  }
}
