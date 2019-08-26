using PS.Utility;
using System;
using System.Collections.Generic;

namespace PS.Model
{
    public class Data
    {
        public static User owner = new User { Id = 1, Name = "Barrett Klein", Role = Roles.Owner, ContactNo = "042-714-9748", Address = "P.O. Box 198, 543 Nisi. Rd.", SSN = "B7556371-422C-F852-D1C5-938203EB2063", CrietedDate = new DateTime(2019, 08, 21) };
        public static List<User> customerList = new List<User>
        {
            new User { Id = 2, Name = "Jesse Richardson", ContactNo = "071-851-1175", Address = "Ap #385-8107 Magna. St.", SSN = "31CEF7B2-3061-F3EC-D95D-05357736DC58", CrietedDate = new DateTime(2018,08,30) },
            new User { Id = 3, Name = "Kennan Sparks", ContactNo = "077-066-6786", Address = "Ap #912-2912 Nulla Road", SSN = "47511F9A-1E0B-54B0-73BC-9C961F326B75", CrietedDate = new DateTime(2019,04,24) },
            new User { Id = 4, Name = "Zachery Cote", ContactNo = "047-232-9622", Address = "2757 Lectus Av.", SSN = "82816999-9C2E-B8ED-878D-7FE706F966C8", CrietedDate = new DateTime(2019,01,09) },
            new User { Id = 5, Name = "Elvis Knox", ContactNo = "099-880-8303", Address = "P.O. Box 721, 9480 Massa Avenue", SSN = "69105ABA-3E47-550B-2204-A662FF994E1B", CrietedDate = new DateTime(2019,01,25) }
        };

        public static List<Pet> pets = new List<Pet>
        {
            new Pet{ Id = 1, Name = "Pamela", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2017,09,22), ChipIdentifier = "MYR90JLI2ZL", InplanteDate = new DateTime(2018,01,08), Price = 2324, Description = "penatibus et magnis dis parturient montes, nascetur ridiculus mus. Proin vel nisl. Quisque fringilla euismod", CrietedDate = new DateTime(2018,08,21) },
            new Pet{ Id = 2, Name = "Wyoming", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2019,01,23), ChipIdentifier = "DMN76FBI1QW", InplanteDate = new DateTime(2018,06,07), Price = 1531, Description = "Proin dolor. Nulla semper tellus id nunc interdum feugiat. Sed nec metus facilisis lorem tristique", CrietedDate = new DateTime(2018,10,09) },
            new Pet{ Id = 3, Name = "Britanni", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2018,05,13), ChipIdentifier = "UKN24GBC3HH", InplanteDate = new DateTime(2018,09,29), Price = 3268, Description = "lectus justo eu arcu. Morbi sit amet massa. Quisque porttitor eros nec tellus. Nunc lectus", CrietedDate = new DateTime(2019,08,12) },
            new Pet{ Id = 4, Name = "Adrienne", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2018,06,26), ChipIdentifier = "LNX38SRL6ML", InplanteDate = new DateTime(2019,08,03), Price = 4731, Description = "rutrum. Fusce dolor quam, elementum at, egestas a, scelerisque sed, sapien. Nunc pulvinar arcu et", CrietedDate = new DateTime(2019,09,01) },
            new Pet{ Id = 5, Name = "Robin", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2018,04,09), ChipIdentifier = "JQI30KMZ0SQ", InplanteDate = new DateTime(2018,10,06), Price = 1954, Description = "ipsum nunc id enim. Curabitur massa. Vestibulum accumsan neque et nunc. Quisque ornare tortor at", CrietedDate = new DateTime(2018,09,15) },
            new Pet{ Id = 6, Name = "Adam", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2018,09,27), ChipIdentifier = "NXN55AUX8SG", InplanteDate = new DateTime(2017,12,01), Price = 1633, Description = "Proin dolor. Nulla semper tellus id nunc interdum feugiat. Sed nec metus facilisis lorem tristique", CrietedDate = new DateTime(2019,06,09) },
            new Pet{ Id = 7, Name = "Amela", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2019,03,28), ChipIdentifier = "FHY08CXX5WE", InplanteDate = new DateTime(2018,05,03), Price = 1078, Description = "eget massa. Suspendisse eleifend. Cras sed leo. Cras vehicula aliquet libero. Integer in magna. Phasellus", CrietedDate = new DateTime(2019,12,09) },
            new Pet{ Id = 8, Name = "Amena", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2017,10,17), ChipIdentifier = "WAY37WEG8IM", InplanteDate = new DateTime(2018,08,30), Price = 3447, Description = "Sed pharetra, felis eget varius ultrices, mauris ipsum porta elit, a feugiat tellus lorem eu", CrietedDate = new DateTime(2019,11,06) },
            new Pet{ Id = 9, Name = "Lysandra", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2017,12,17), ChipIdentifier = "OUS44XDO3GL", InplanteDate = new DateTime(2017,11,28), Price = 4105, Description = "consectetuer mauris id sapien. Cras dolor dolor, tempus non, lacinia at, iaculis quis, pede. Praesent", CrietedDate = new DateTime(2019,06,08) },
            new Pet{ Id = 10, Name = "Sonya", PetType = PetTypes.Dog, DateOfBirth = new DateTime(2019,03,10), ChipIdentifier = "GTF91WTI3YS", InplanteDate = new DateTime(2019,07,21), Price = 1844, Description = "In nec orci. Donec nibh. Quisque nonummy ipsum non arcu. Vivamus sit amet risus. Donec", CrietedDate = new DateTime(2019,11,16) },

            new Pet{ Id = 11, Name = "Eugenia", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2019,02,27), ChipIdentifier = "RGO04QGH2YM", InplanteDate = new DateTime(2017,12,04), Price = 1457, Description = "sollicitudin adipiscing ligula. Aenean gravida nunc sed pede. Cum sociis natoque penatibus et magnis dis", CrietedDate = new DateTime(2020,03,19) },
            new Pet{ Id = 12, Name = "Lana", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2017,11,08), ChipIdentifier = "BRO73RUO8XO", InplanteDate = new DateTime(2018,02,23), Price = 2292, Description = "non, vestibulum nec, euismod in, dolor. Fusce feugiat. Lorem ipsum dolor sit amet, consectetuer adipiscing", CrietedDate = new DateTime(2020,08,09) },
            new Pet{ Id = 13, Name = "Bree", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2017,09,08), ChipIdentifier = "JTM98AOP6SN", InplanteDate = new DateTime(2017,11,17), Price = 1211, Description = "a mi fringilla mi lacinia mattis. Integer eu lacus. Quisque imperdiet, erat nonummy ultricies ornare,", CrietedDate = new DateTime(2020,01,20) },
            new Pet{ Id = 14, Name = "Lael", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2018,09,01), ChipIdentifier = "LZU57DWZ3VJ", InplanteDate = new DateTime(2018,07,29), Price = 1364, Description = "aliquam, enim nec tempus scelerisque, lorem ipsum sodales purus, in molestie tortor nibh sit amet", CrietedDate = new DateTime(2018,11,19) },
            new Pet{ Id = 15, Name = "Bruce", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2018,05,17), ChipIdentifier = "QVD78JUF0MC", InplanteDate = new DateTime(2019,06,06), Price = 3803, Description = "semper tellus id nunc interdum feugiat. Sed nec metus facilisis lorem tristique aliquet. Phasellus fermentum", CrietedDate = new DateTime(2019,07,21) },
            new Pet{ Id = 16, Name = "Serena", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2017,09,23), ChipIdentifier = "AZE40YBO6MH", InplanteDate = new DateTime(2018,03,03), Price = 1143, Description = "turpis egestas. Aliquam fringilla cursus purus. Nullam scelerisque neque sed sem egestas blandit. Nam nulla", CrietedDate = new DateTime(2019,10,04) },
            new Pet{ Id = 17, Name = "Jordan", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2018,10,18), ChipIdentifier = "WUN59ENZ3RM", InplanteDate = new DateTime(2018,11,18), Price = 3904, Description = "fermentum metus. Aenean sed pede nec ante blandit viverra. Donec tempus, lorem fringilla ornare placerat,", CrietedDate = new DateTime(2020,04,14) },
            new Pet{ Id = 18, Name = "Rylee", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2018,01,06), ChipIdentifier = "KWI44XKV8GB", InplanteDate = new DateTime(2017,11,19), Price = 3477, Description = "odio, auctor vitae, aliquet nec, imperdiet nec, leo. Morbi neque tellus, imperdiet non, vestibulum nec,", CrietedDate = new DateTime(2019,04,11) },
            new Pet{ Id = 19, Name = "Blossom", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2018,03,07), ChipIdentifier = "ZTQ01UMF3RF", InplanteDate = new DateTime(2019,07,30), Price = 2945, Description = "ipsum dolor sit amet, consectetuer adipiscing elit. Aliquam auctor, velit eget laoreet posuere, enim nisl", CrietedDate = new DateTime(2020,06,23) },
            new Pet{ Id = 20, Name = "Rooney", PetType = PetTypes.Cat, DateOfBirth = new DateTime(2018,06,04), ChipIdentifier = "UBX73EBB0NV", InplanteDate = new DateTime(2018,02,07), Price = 4746, Description = "gravida sit amet, dapibus id, blandit at, nisi. Cum sociis natoque penatibus et magnis dis", CrietedDate = new DateTime(2019,09,29) },

            new Pet{ Id = 21, Name = "Marvin", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2018,03,26), ChipIdentifier = "IGV10RYM0KU", InplanteDate = new DateTime(2018,03,29), Price = 4217, Description = "ipsum sodales purus, in molestie tortor nibh sit amet orci. Ut sagittis lobortis mauris. Suspendisse", CrietedDate = new DateTime(2019,12,09) },
            new Pet{ Id = 22, Name = "Lewis", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2019,02,02), ChipIdentifier = "BHT00AUQ6QI", InplanteDate = new DateTime(2018,05,02), Price = 4830, Description = "ridiculus mus. Aenean eget magna. Suspendisse tristique neque venenatis lacus. Etiam bibendum fermentum metus. Aenean", CrietedDate = new DateTime(2019,10,28) },
            new Pet{ Id = 23, Name = "Ayanna", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2019,07,09), ChipIdentifier = "DZY35BDF0YR", InplanteDate = new DateTime(2019,06,14), Price = 2931, Description = "lorem. Donec elementum, lorem ut aliquam iaculis, lacus pede sagittis augue, eu tempor erat neque", CrietedDate = new DateTime(2020,03,26) },
            new Pet{ Id = 24, Name = "Otto", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2019,03,15), ChipIdentifier = "JBU30QAW1ZU", InplanteDate = new DateTime(2019,02,01), Price = 1480, Description = "risus a ultricies adipiscing, enim mi tempor lorem, eget mollis lectus pede et risus. Quisque", CrietedDate = new DateTime(2018,11,01) },
            new Pet{ Id = 25, Name = "Gwendolyn", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2018,12,24), ChipIdentifier = "HIT02OFH2CI", InplanteDate = new DateTime(2018,04,09), Price = 4603, Description = "arcu. Curabitur ut odio vel est tempor bibendum. Donec felis orci, adipiscing non, luctus sit", CrietedDate = new DateTime(2018,12,11) },
            new Pet{ Id = 26, Name = "Quyn", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2017,10,30), ChipIdentifier = "NEP79QTW0LR", InplanteDate = new DateTime(2019,04,01), Price = 2527, Description = "risus. In mi pede, nonummy ut, molestie in, tempus eu, ligula. Aenean euismod mauris eu", CrietedDate = new DateTime(2018,08,25) },
            new Pet{ Id = 27, Name = "Camilla", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2017,09,21), ChipIdentifier = "PGG99APB8WH", InplanteDate = new DateTime(2018,01,23), Price = 3558, Description = "lacus. Etiam bibendum fermentum metus. Aenean sed pede nec ante blandit viverra. Donec tempus, lorem", CrietedDate = new DateTime(2019,04,25) },
            new Pet{ Id = 28, Name = "Pamela", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2018,05,25), ChipIdentifier = "KWQ12ALB0FC", InplanteDate = new DateTime(2018,02,14), Price = 3425, Description = "elit sed consequat auctor, nunc nulla vulputate dui, nec tempus mauris erat eget ipsum. Suspendisse", CrietedDate = new DateTime(2019,09,23) },
            new Pet{ Id = 29, Name = "Vladimir", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2019,02,13), ChipIdentifier = "ZQA23GVD1BI", InplanteDate = new DateTime(2019,03,25), Price = 1733, Description = "placerat, augue. Sed molestie. Sed id risus quis diam luctus lobortis. Class aptent taciti sociosqu", CrietedDate = new DateTime(2019,10,01) },
            new Pet{ Id = 30, Name = "Alexis", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2019,03,06), ChipIdentifier = "ZCJ45OCL9KJ", InplanteDate = new DateTime(2019,07,15), Price = 3577, Description = "eget, ipsum. Donec sollicitudin adipiscing ligula. Aenean gravida nunc sed pede. Cum sociis natoque penatibus", CrietedDate = new DateTime(2019,02,28) },
            new Pet{ Id = 31, Name = "Carla", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2018,09,06), ChipIdentifier = "BAU62HIJ8SH", InplanteDate = new DateTime(2018,06,24), Price = 4785, Description = "Aliquam nec enim. Nunc ut erat. Sed nunc est, mollis non, cursus non, egestas a,", CrietedDate = new DateTime(2019,10,08) },
            new Pet{ Id = 32, Name = "Buckminster", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2017,10,25), ChipIdentifier = "XBO36MNS2HY", InplanteDate = new DateTime(2018,09,04), Price = 4725, Description = "erat nonummy ultricies ornare, elit elit fermentum risus, at fringilla purus mauris a nunc. In", CrietedDate = new DateTime(2019,12,17) },
            new Pet{ Id = 33, Name = "Alea", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2018,08,03), ChipIdentifier = "QJW88HJG8PA", InplanteDate = new DateTime(2018,08,05), Price = 3528, Description = "mi fringilla mi lacinia mattis. Integer eu lacus. Quisque imperdiet, erat nonummy ultricies ornare, elit", CrietedDate = new DateTime(2019,08,14) },
            new Pet{ Id = 34, Name = "Alice", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2017,12,14), ChipIdentifier = "IVW40AOH2LM", InplanteDate = new DateTime(2019,08,06), Price = 1331, Description = "Sed eget lacus. Mauris non dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum", CrietedDate = new DateTime(2019,01,31) },
            new Pet{ Id = 35, Name = "Clarke", PetType = PetTypes.Bird, DateOfBirth = new DateTime(2018,05,20), ChipIdentifier = "CDT40TXA8CZ", InplanteDate = new DateTime(2019,05,27), Price = 1162, Description = "molestie arcu. Sed eu nibh vulputate mauris sagittis placerat. Cras dictum ultricies ligula. Nullam enim.", CrietedDate = new DateTime(2020,03,10) }
        };

        public static List<Transaction> transactions = new List<Transaction>
        {
            new Transaction { Id = 1, PetId = 34, UserId = 5, CrietedDate = new DateTime(2019,08,24), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 2, PetId = 4, UserId = 4, CrietedDate = new DateTime(2019,08,14), TransType = TransTypes.ByCash },
            new Transaction { Id = 3, PetId = 2, UserId = 4, CrietedDate = new DateTime(2019,08,15), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 4, PetId = 12, UserId = 5, CrietedDate = new DateTime(2019,08,01), TransType = TransTypes.ByCash },
            new Transaction { Id = 5, PetId = 22, UserId = 5, CrietedDate = new DateTime(2019,08,26), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 6, PetId = 6, UserId = 2, CrietedDate = new DateTime(2019,08,01), TransType = TransTypes.ByCash },
            new Transaction { Id = 7, PetId = 16, UserId = 3, CrietedDate = new DateTime(2019,08,17), TransType = TransTypes.ByCash },
            new Transaction { Id = 8, PetId = 1, UserId = 5, CrietedDate = new DateTime(2019,08,22), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 9, PetId = 25, UserId = 3, CrietedDate = new DateTime(2019,08,30), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 10, PetId = 10, UserId = 5, CrietedDate = new DateTime(2019,08,22), TransType = TransTypes.ByCash },
            new Transaction { Id = 11, PetId = 17, UserId = 4, CrietedDate = new DateTime(2019,08,24), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 12, PetId = 31, UserId = 2, CrietedDate = new DateTime(2019,08,22), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 13, PetId = 28, UserId = 3, CrietedDate = new DateTime(2019,08,10), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 14, PetId = 20, UserId = 2, CrietedDate = new DateTime(2019,07,31), TransType = TransTypes.ByCash },
            new Transaction { Id = 15, PetId = 25, UserId = 3, CrietedDate = new DateTime(2019,08,24), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 16, PetId = 33, UserId = 3, CrietedDate = new DateTime(2019,08,15), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 17, PetId = 24, UserId = 4, CrietedDate = new DateTime(2019,07,31), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 18, PetId = 35, UserId = 4, CrietedDate = new DateTime(2019,08,30), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 19, PetId = 10, UserId = 4, CrietedDate = new DateTime(2019,08,08), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 20, PetId = 30, UserId = 4, CrietedDate = new DateTime(2019,08,01), TransType = TransTypes.ByCash },
            new Transaction { Id = 21, PetId = 20, UserId = 2, CrietedDate = new DateTime(2019,08,29), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 22, PetId = 23, UserId = 3, CrietedDate = new DateTime(2019,08,13), TransType = TransTypes.ByCash },
            new Transaction { Id = 23, PetId = 21, UserId = 5, CrietedDate = new DateTime(2019,08,15), TransType = TransTypes.ByInsurance },
            new Transaction { Id = 24, PetId = 29, UserId = 5, CrietedDate = new DateTime(2019,08,01), TransType = TransTypes.ByUpfront },
            new Transaction { Id = 25, PetId = 32, UserId = 5, CrietedDate = new DateTime(2019,08,08), TransType = TransTypes.ByInsurance }
        };

    }
}
