using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplication24082026.Data
{
    public static class StaticJsonValues
    {
        public static string textJson = @"[ " +
"{\"Name\": \"John Doe\", \"Specification\":\"VB.Net\",\"CategoryName\":\"Helmets\", \"ListPrice\": \"130\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Юго-западная\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Jane Doe\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"128\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Юго-западная\",\"DataBase\": \"Postgresql\"   }," +
"{ \"Name\": \"Alice Smith\", \"Specification\":\"C#\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Юго-западная\",\"DataBase\": \"Postgresql\"   }," +
"{ \"Name\": \"Cooper Smith\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Юго-западная\",\"DataBase\": \"Postgresql\"   }," +
"{ \"Name\": \"John Smith\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"205\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Юго-западная\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Bob Smith\", \"Specification\":\"C++\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"215\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Юго-западная\",\"DataBase\": \"Oracle\"   }," +
"{ \"Name\": \"Jane Doe\", \"Specification\":\"TypeScript\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"128\", \"Description\": \"Описание функционала WPF\", \"Address\": \"Москва, Перово\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Alice Smith\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\" , \"Address\": \"Москва, Перово\",\"DataBase\": \"MSSQL\"   }," +
"{ \"Name\": \"Cooper Smith\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\" , \"Address\": \"Москва, Перово\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"John Smith\", \"Specification\":\"C++\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"205\", \"Description\": \"Описание функционала WPF\" , \"Address\": \"Москва, Перово\",\"DataBase\": \"Oracle\"   }," +
"{ \"Name\": \"Bob Smith\", \"Specification\":\"SQL\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"215\", \"Description\": \"Описание функционала WPF\" , \"Address\": \"Москва, Перово\",\"DataBase\": \"Oracle\"   }," +
"{ \"Name\": \"Jane Doe\", \"Specification\":\"Javascript\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"128\", \"Description\": \"Описание функционала WPF\" , \"Address\": \"Москва, Перово\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Alice Smith\", \"Specification\":\"C#\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Прощадь Ленина\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Cooper Smith\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Прощадь Ленина\" ,\"DataBase\": \"Oracle\"   }," +
"{ \"Name\": \"John Smith\", \"Specification\":\"TypeScript\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"205\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Прощадь Ленина\" ,\"DataBase\": \"MSSQL\"   }," +
"{ \"Name\": \"Bob Smith\", \"Specification\":\"SQL\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"215\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Прощадь Ленина\",\"DataBase\": \"MSSQL\"   }," +
"{ \"Name\": \"Mark Twen\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"128\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Ждановская\",\"DataBase\": \"Postgresql\"   }," +
"{ \"Name\": \"Mark Twen\", \"Specification\":\"C#\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Ждановская\",\"DataBase\": \"Postgresql\"   }," +
"{ \"Name\": \"Vladimir Moscow\", \"Specification\":\"TypeScript\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"205\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Ждановская\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Vladimir Moscow\", \"Specification\":\"SQL\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"215\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Ждановская\" ,\"DataBase\": \"Postgresql\"   }," +
"{ \"Name\": \"Vladimir Moscow\", \"Specification\":\"C++\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"128\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Ждановская\",\"DataBase\": \"MSSQL\"   }," +
"{ \"Name\": \"Vladimir Moscow\", \"Specification\":\"C#\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Первомайская\",\"DataBase\": \"Oracle\"   }," +
"{ \"Name\": \"Vladimir Moscow\", \"Specification\":\"VB.Net\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Первомайская\",\"DataBase\": \"Postgresql\"   }," +
"{ \"Name\": \"Vladimir Moscow\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"205\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Первомайская\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Mark Twen\", \"Specification\":\"Java\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"125\", \"Description\": \"Описание функционала WPF\",\"Address\": \"Москва, Первомайская\",\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Mark Twen\", \"Specification\":\"VB.Net\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"205\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Первомайская\" ,\"DataBase\": \"MSSQL\"   }," +
"{ \"Name\": \"Mark Twen\", \"Specification\":\"SQL\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"215\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Первомайская\" ,\"DataBase\": \"MongoDB\"   }," +
"{ \"Name\": \"Sara Smith\", \"Specification\":\"TypeScript\", \"CategoryName\":\"Helmets\", \"ListPrice\": \"235\", \"Description\": \"Описание функционала WPF\" ,\"Address\": \"Москва, Первомайская\",\"DataBase\": \"MongoDB\" }]";

    }
}
