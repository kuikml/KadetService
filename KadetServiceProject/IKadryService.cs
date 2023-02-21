using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace KadetServiceProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IKadryService
    {
        [OperationContract]
        Pracownik DodajPracownika(Pracownik pracownik, string haslo);

        [OperationContract]
        void ModyfikujPracownika(Pracownik pracownik, string pesel);

        [OperationContract]
        void UsunPracownika(string pesel);

        [OperationContract]
        Pracownik[] WyszukajPracownika(string fraza);

        // TODO: Add your service operations here
    }
}
