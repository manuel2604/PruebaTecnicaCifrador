using Cifrador.Application;
using Cifrador.Application.ApplicationService;
using Cifrador.Domain.Entity;
using Cifrador.Domain.Repository;
using Cifrador.Infrastructure.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cifrado.MSTest
{
    [TestClass]
    public class TestsCifrador
    {
        [TestMethod]
        public void CifrarLetra()
        {
            var mongoRepository = new MongoRepository<LetraCifrada, string>("mongodb://127.0.0.1:27017", "CriptoDB");
            mongoRepository.InitialCharge();
            Assert.AreEqual("..-...", mongoRepository.FindById("A").Marciano);
        }

        [TestMethod]
        public void CifrarPalabra()
        {
            var mongoRepository = new MongoRepository<LetraCifrada, string>("mongodb://127.0.0.1:27017", "CriptoDB");
            mongoRepository.InitialCharge();
            var appService = new CifrarFraseApplicationService(mongoRepository);
            Assert.AreEqual(".---....-...---.....-..-...-..--....", appService.CifrarPalabra("Manuel"));
        }

        [TestMethod]
        public void CifrarFrase()
        {
            var mongoRepository = new MongoRepository<LetraCifrada, string>("mongodb://127.0.0.1:27017", "CriptoDB");
            mongoRepository.InitialCharge();
            var appService = new CifrarFraseApplicationService(mongoRepository);
            Assert.AreEqual(".--...--..-.--......-... .---....-..----.....-...--..-. ...-..-....-.-.-.-..-... ...-..-....- ..-..----.....-... -..--...-.....-..-...-..-.......-... ..-..----.....-....-.-.-..-.....-.....-.....-... ", 
                appService.CifrarFrase("Hola mundo esta es una prueba unitaria"));
        }
    }
}
