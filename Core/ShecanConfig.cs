using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abdal_Security_Group_App.Core
{
    internal class ShecanConfig
    {
        // Static method to save the configuration data
        public static void SaveConfig(string filePath, string shecanPro, string shecanIpUpdaterCode, string shekanIpUpdaterStatus, string shecanIpUpdaterTimeValue)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                // Create a new file and write the data to it
                XDocument newDoc = new XDocument(
                    new XElement("Configuration",
                        new XElement("shecan_pro", shecanPro),
                        new XElement("shecan_ip_updater_code", shecanIpUpdaterCode),
                        new XElement("shekan_ip_updater_status", shekanIpUpdaterStatus),
                        new XElement("shecan_ip_updater_time_value", shecanIpUpdaterTimeValue)
                    )
                );
                newDoc.Save(filePath);
            }
            else
            {
                // If the file exists, load it and update the data
                XDocument existingDoc = XDocument.Load(filePath);
                XElement root = existingDoc.Element("Configuration");

                root.Element("shecan_pro").Value = shecanPro;
                root.Element("shecan_ip_updater_code").Value = shecanIpUpdaterCode;
                root.Element("shekan_ip_updater_status").Value = shekanIpUpdaterStatus;
                root.Element("shecan_ip_updater_time_value").Value = shecanIpUpdaterTimeValue;

                existingDoc.Save(filePath);
            }
        }




        // Static method to retrieve the configuration data and return it as a dictionary
        public static Dictionary<string, string> RetrieveConfig(string filePath)
        {
            var configData = new Dictionary<string, string>();

            // Check if the file exists
            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);
                XElement root = doc.Element("Configuration");

                configData["shecan_pro"] = root.Element("shecan_pro")?.Value ?? string.Empty;
                configData["shecan_ip_updater_code"] = root.Element("shecan_ip_updater_code")?.Value ?? string.Empty;
                configData["shekan_ip_updater_status"] = root.Element("shekan_ip_updater_status")?.Value ?? string.Empty;
                configData["shecan_ip_updater_time_value"] = root.Element("shecan_ip_updater_time_value")?.Value ?? string.Empty;

            }
            else
            {
                SaveConfig(
                    PubVar.configFilePath,
                    "no",
                    "",
                    "no",
                    "10"
                    );
            }

            return configData;
        }

    }
}
