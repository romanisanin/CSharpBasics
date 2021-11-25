using System;
using System.Configuration;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.AppSettings["Greetings"]);

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = configFile.FilePath };
            Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            var settings = configuration.AppSettings.Settings;

            if (settings["Name"].Value != String.Empty)
            {
                Console.WriteLine($"Hello, {settings["Name"].Value}");
            }
            if (settings["Age"].Value != String.Empty)
            {
                Console.WriteLine($"Your Age is {settings["Age"].Value}");
            }
            if (settings["Job"].Value != String.Empty)
            {
                Console.WriteLine($"Your Job Title is {settings["Job"].Value}");
            }


            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            AddOrUpdateAppSettings("Name", name, ConfigurationUserLevel.PerUserRoaming);
            Console.WriteLine("Enter your Age:");
            string age = Console.ReadLine();
            AddOrUpdateAppSettings("Age", age, ConfigurationUserLevel.PerUserRoaming);
            Console.WriteLine("Enter your Job title:");
            string job = Console.ReadLine();
            AddOrUpdateAppSettings("Job", job, ConfigurationUserLevel.PerUserRoaming);

         }

        public static void AddOrUpdateAppSettings(string key, string value, ConfigurationUserLevel configurationUserLevel)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(configurationUserLevel);
                var fileMap = new ExeConfigurationFileMap {ExeConfigFilename = configFile.FilePath };
                Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                
                var settings = configuration.AppSettings.Settings;

                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }

                configuration.Save();
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}
//Создать консольное приложение, которое при старте выводит приветствие, записанное в настройках приложения (application-scope).
//Запросить у пользователя имя, возраст и род деятельности, а затем сохранить данные в настройках.
//При следующем запуске отобразить эти сведения. Задать приложению версию и описание.