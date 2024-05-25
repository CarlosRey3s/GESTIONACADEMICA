import { environment } from "../../environments/environment.development";

export const endpoints = {
    agregarEstudiante : environment.serverURL.concat("api/estudiantes/agregarEstudiante"),
    ActualizarEstudiante : environment.serverURL.concat("api/estudiantes/actualizarEstudiante"),
    EliminarEstudiante : environment.serverURL.concat("api/estudiantes/eliminarEstudiante"),
    ObtenerEstudiantePorID : environment.serverURL.concat("api/estudiantes/ObtenerEstudiantesPorID"),
    ObtenerEstudiante : environment.serverURL.concat("api/estudiantes/obtenerEstudiantes"),
};