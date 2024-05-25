import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable, endWith } from 'rxjs';
import { endpoints } from '../utils/enpoints';

@Injectable({
  providedIn: 'root'
})
export class EstudiantesService {

  private readonly http = inject(HttpClient);
  
constructor() { }

obtenerEstudintes(): Observable<any>{
  return this.http.get(endpoints.ObtenerEstudiante);
}

}
