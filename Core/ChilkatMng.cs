using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Security_Group_App.Core
{
    class ChilkatMng
    {
        public static void UnlockChilkat()
        {
            // Start Global Chilkat Unlock
            Chilkat.Global glob = new Chilkat.Global();

            // old version Exp 12/2029  abdalI.CBX1129_YZBj6M2wDZ3a
            // New version 1API54.CBX082024_6EUSP9H0lGpG
            bool success = glob.UnlockBundle("1API54.CBX082024_6EUSP9H0lGpG");
            if (success != true)
            {
                //encoder.listBox1.Items.Add(glob.LastErrorText);
                MessageBox.Show("Module Error");
            }

            int status = glob.UnlockStatus;
            if (status == 2)
            {
                //listBox1.Items.Add("Unlocked using purchased unlock code.");
                //MessageBox.Show("Unlocked using purchased unlock code.");
            }
            else
            {
                //listBox1.Items.Add("Unlocked in trial mode.");
                MessageBox.Show("Unlocked in trial mode.");
            }
        }

        // MD5 enc
        public static string StringToMD5(string RawStr)
        {
            Chilkat.Crypt2 cryptMd5 = new Chilkat.Crypt2();
            cryptMd5.HashAlgorithm = "md5";
            cryptMd5.EncodingMode = "hex";
            string Md5Ready = cryptMd5.HashStringENC(RawStr);
            cryptMd5.Dispose();
            return Md5Ready;
        }
    }
}