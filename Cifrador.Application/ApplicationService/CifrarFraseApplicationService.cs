using Cifrador.Domain.Entity;
using Cifrador.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cifrador.Application.ApplicationService
{
    public class CifrarFraseApplicationService: ICifrarFraseApplicationService
    { 
        private readonly IRepository<LetraCifrada, string> repository;

        public CifrarFraseApplicationService(IRepository<LetraCifrada, string> repository)
        {
            this.repository = repository;
        }

        public string CifrarFrase(string FraseACifrar)
        {
            string[] Palabras = FraseACifrar.ToUpper().Split(" ");
            string FraseCifrada = "";
            foreach (string Palabra in Palabras)
            {
                 FraseCifrada += $"{CifrarPalabra(Palabra)} ";
            }
            return FraseCifrada;
        }

        public string CifrarPalabra(string PalabraACifrar)
        {
            string PalabraCifrada = "";
            foreach (char letra in PalabraACifrar)
            {
                PalabraCifrada += $"{repository.FindById(letra.ToString().ToUpper()).Marciano}";
            }
            return PalabraCifrada;
        }
    }
}
