using System;
using System.Collections.Generic;
using System.IO;

namespace PixelPass
{
    public class AccountInfoCollectionReader
    {
        public static IAccountInfoCollection Read(string filename)
        {
            var accountInfoCollection = new AccountInfoCollection();
            using (var accountFileReader = File.OpenText(filename))
            {
                var line = accountFileReader.ReadLine();
                if (line == null || !line.StartsWith("Name:"))
                {
                    throw new ParseException($"{filename} seems corrupt.\nDetails:\n{filename} does not start \nwith Name:");
                }

                accountInfoCollection.Name = line.Substring(5, line.Length - 5);
                line = accountFileReader.ReadLine();
                accountInfoCollection.AccountInfos = new List<AccountInfo>();

                while (line != null)
                {
                    var accountInfoStrings = line.Split(',');
                    var accountInfo = new AccountInfo
                    {
                        Title = accountInfoStrings[0],
                        Username = accountInfoStrings[1],
                        Password = accountInfoStrings[2],
                        Notes = accountInfoStrings[3],
                        Expiration = Convert.ToDateTime(accountInfoStrings[4])
                    };

                    accountInfoCollection.AccountInfos.Add(accountInfo);
                    line = accountFileReader.ReadLine();
                }
            }

            return accountInfoCollection;
        }
    }
}
