import { environment } from "../../environments/environment.development";
//ESTUDIANTE
export const endpoints = {
    agregarEstudiante : environment.serverURL.concat("api/estudiantes/agregarEstudiante"),
    ActualizarEstudiante : environment.serverURL.concat("api/estudiantes/actualizarEstudiante"),
    EliminarEstudiante : environment.serverURL.concat("api/estudiantes/eliminarEstudiante"),
    ObtenerEstudiantePorID : environment.serverURL.concat("api/estudiantes/ObtenerEstudiantesPorID"),
    ObtenerEstudiante : environment.serverURL.concat("api/estudiantes/obtenerEstudiantes"),

//CARRERA
    agregarCarrera : environment.serverURL.concat("api/carrera/agregarCarrera"),
    actualizarCarrera : environment.serverURL.concat("api/carrera/actualizarCarrera"),
    eliminarCarrera : environment.serverURL.concat("api/carrera/eliminarCarrera"),
    obtenerCarreraPorID : environment.serverURL.concat("api/carrera/obtenerCarreraPorID"),
    obtenerCarrera : environment.serverURL.concat("api/carrera/obtenerCarrera"),
//GRUPO
    agregarGrupo : environment.serverURL.concat("api/grupo/agregarGrupo"),
    actualizarGrupo : environment.serverURL.concat("api/grupo/actualizarGrupo"),
    eliminarGrupo : environment.serverURL.concat("api/grupo/eliminarGrupo"),
    obtenerGrupoPorID : environment.serverURL.concat("api/grupo/obtenerGrupoPorID"),
    obtenerGrupo : environment.serverURL.concat("api/grupo/obtenerGrupo"),
//MATERIA
    agregarMateria : environment.serverURL.concat("api/materias/agregarMateria"),
    actualizarMateria : environment.serverURL.concat("api/materias/actualizarMateria"),
    eliminarMateria : environment.serverURL.concat("api/materias/eliminarMateria"),
    obtenerMateriaPorID : environment.serverURL.concat("api/materias/obtenerMateriaPorID"),
    obtenerMateria : environment.serverURL.concat("api/materias/obtenerMateria"),
//PROFESOR
    agregarProfesor : environment.serverURL.concat("api/profesor/agregarProfesor"),
    actualizarProfesor : environment.serverURL.concat("api/profesor/actualizarProfesor"),
    eliminarProfesor : environment.serverURL.concat("api/profesor/eliminarProfesor"),
    obtenerProfesorPorID : environment.serverURL.concat("api/profesor/obtenerProfesorPorID"),
    obtenerProfesor : environment.serverURL.concat("api/profesor/obtenerProfesor"),

};