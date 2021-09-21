using System.Collections.Generic;
using HospitalEnCasa.app.Dominio;

namespace HospitalEnCasa.app.Persistencia{
    public interface IRepositorioPaciente{
        IEnumerable<Paciente> getAllPacientes();
        Paciente addPaciente(Paciente paciente);
        Paciente editPaciente(Paciente paciente);
        Paciente getPaciente(int cedula);
        void RemovePaciente(int cedula);
    }
}