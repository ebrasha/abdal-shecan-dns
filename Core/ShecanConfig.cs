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
        public static void SaveConfig(
            string filePath,
            string shecanPro,
            string shecanIpUpdaterCode,
            string shekanIpUpdaterStatus,
            string AudioNotificationStatus,
            string shecanIpUpdaterTimeValue,
            string dnsType
            )
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
                        new XElement("audio_notification_status", AudioNotificationStatus),
                        new XElement("shecan_ip_updater_time_value", shecanIpUpdaterTimeValue),
                        new XElement("dns_type", dnsType)
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
                root.Element("audio_notification_status").Value = AudioNotificationStatus;
                root.Element("shecan_ip_updater_time_value").Value = shecanIpUpdaterTimeValue;
                root.Element("dns_type").Value = dnsType;

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

                // Define default values
                var defaultValues = new Dictionary<string, string>
                        {
                            {"shecan_pro", "no"},
                            {"shecan_ip_updater_code", ""},
                            {"shekan_ip_updater_status", "no"},
                            {"audio_notification_status", "yes"},
                            {"shecan_ip_updater_time_value", "10"},
                             {"dns_type", "def"}

                        };

                XDocument doc = XDocument.Load(filePath);
                XElement root = doc.Element("Configuration");

                if (root == null)
                {
                    root = new XElement("Configuration");
                    doc.Add(root);
                }

                foreach (var key in defaultValues.Keys)
                {
                    var element = root.Element(key);
                    if (element == null)
                    {
                        // Add missing element with default value
                        root.Add(new XElement(key, defaultValues[key]));
                    }

                    configData[key] = element?.Value ?? defaultValues[key];
                }

                // Save changes if any elements were added
                doc.Save(filePath);

                configData["shecan_pro"] = root.Element("shecan_pro")?.Value ?? string.Empty;
                configData["shecan_ip_updater_code"] = root.Element("shecan_ip_updater_code")?.Value ?? string.Empty;
                configData["shekan_ip_updater_status"] = root.Element("shekan_ip_updater_status")?.Value ?? string.Empty;
                configData["audio_notification_status"] = root.Element("audio_notification_status")?.Value ?? string.Empty;
                configData["shecan_ip_updater_time_value"] = root.Element("shecan_ip_updater_time_value")?.Value ?? string.Empty;
                configData["dns_type"] = root.Element("dns_type")?.Value ?? string.Empty;

            }
            else
            {
                SaveConfig(
                    PubVar.configFilePath,
                    "no",
                    "",
                    "no",
                    "no",
                    "10",
                    "def"
                    );
            }

            return configData;
        }

    }
}
