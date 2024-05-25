import { Component, inject } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EstudiantesService } from './services/estudiantes.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'GestionAcademica';

  private readonly estudiantesServices = inject(EstudiantesService);

  estudiantes$ = this.estudiantesServices.obtenerEstudintes();
}
