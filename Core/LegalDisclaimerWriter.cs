using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    internal class LegalDisclaimerWriter
    {
        public static string Legal_disclaimer_content()
        {
            string software_name = "Abdal Shecan DNS";
            string software_project_url = "https://abdalarsenal.ir";
            string software_project_name = "Abdal Arsenal";
            string programmer_name = "Ebrahim Shafiei";
            string programmer_email = "Prof.Shafiei@Gmail.com";
            string programmer_url = "https://ebrasha.com";
            string Last_updated = "Feb 26, 2024";
            string content = $@"Legal Disclaimer for {software_name}
Last updated: {Last_updated}
This Legal Disclaimer applies to the {software_name} software application (""the Software""), developed and provided by {programmer_name} as part of the {software_project_name} project. The use of the Software is subject to the following terms and conditions, which are designed to ensure that the Software is used in a lawful and ethical manner.

Legal Use Requirement: Users are required to use the Software in compliance with all applicable laws and regulations. The Software is designed for legitimate purposes, including but not limited to enhancing cybersecurity measures, facilitating secure data transfer, and conducting authorized ethical hacking activities. Ethical hacking, or hacking in compliance with applicable laws, is permitted to identify and rectify security vulnerabilities. Any use of the Software for illegal activities, other than authorized ethical hacking, is expressly prohibited and will be deemed a violation of these terms.

Advertisements and User Rights: We reserve the right to display advertisements within the Software as necessary. Despite this, we hold a steadfast commitment to respecting user rights and privacy. All user rights are protected, and we pledge to maintain the confidentiality and integrity of user data to the fullest extent possible.

Intellectual Property and Ownership: The Software is developed by {programmer_name} and is part of the larger {software_project_name} project. The aim of this project is to contribute to the future of cybersecurity and enhance global security infrastructure. Users of the Software must acknowledge that all intellectual property rights are owned by the developer and the {software_project_name} project.

Contact Information: For inquiries, support, or feedback, users can contact {programmer_name} directly at {programmer_email}. Additional information about the developer and the {software_project_name} project can be found on their respective websites: {programmer_url} for the developer's site and {software_project_url} for the {software_project_name} project.

Disclaimer of Liability: The developer disclaims all liability for any misuse of the Software and any legal consequences that may arise from such misuse. Users are solely responsible for ensuring their use of the Software complies with all legal and regulatory requirements.

By using the {software_name}, users acknowledge and agree to these terms, affirming their commitment to lawful, ethical, and authorized use of the Software. This Legal Disclaimer is intended to promote responsible use and ensure that the Software contributes positively to the cybersecurity community.
";

            return content;
        }
    }
}