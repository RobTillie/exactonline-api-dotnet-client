using ExactOnline.Client.Models;
using ExactOnline.Client.Sdk.Controllers;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
            var task = MainAsync();
            var result = task.Result;

            Console.ReadKey();
		}

        static async Task<int> MainAsync()
        {
            // These are the authorisation properties of your app.
            // You can find the values in the App Center when you are maintaining the app.
            const string clientId = "b4e43a22-ab19-4531-9d5a-e08702dad431";
            const string clientSecret = "rur2OsABYUgG";

            // This can be any url as long as it is identical to the callback url you specified for your app in the App Center.
            var callbackUrl = new Uri("http://cup-it.net");

            var connector = new Connector(clientId, clientSecret, callbackUrl);
            var client = new ExactOnlineClient();
            await client.Initialize(connector.EndPoint, connector.GetAccessToken);

            var me = await client.CurrentMe();
            Console.WriteLine(me.CurrentDivision);

            // Get the Code and Name of a random account in the administration
            //var fields = new[] { "Code", "Name" };
            //var account = client.For<Account>().Top(1).Select(fields).GetAsync().Result.FirstOrDefault();
            //Debug.WriteLine("Account {0} - {1}", account.Code.TrimStart(), account.Name);

            var fields = new[] { "ID", "Created", "Modified" };
            var filter = $"FinancialYear eq 2015";
            //var data = await client.For<TransactionLine>().Select(fields).Where(filter).GetAllAsync();

            var data = await client.For<TransactionLine>().Select(fields).Where(filter).GetAllModifiedAfterAsync(new DateTime(2017, 1, 13, 11, 00, 00));

            foreach (var d in data)
            {
                Console.WriteLine($"{d.Created} | {d.Modified}");
            }

            //var defaultMailbox = await client.GetDefaultMailbox();

            // Create the mail
            // Type 1000 = Inkoop factuur

            //var msg = new MailMessage
            //{
            //    RecipientMailboxID = defaultMailbox.ID,
            //    SenderMailboxID = defaultMailbox.ID,
            //    Type = 1000,
            //    Subject = "hello"
            //};

            //var result = await client.For<MailMessage>().InsertAsync(msg);

            //var fields = new[] { "Code", "CustomerName", "CustomerCode", "Description" };
            //var divisions = await client.For<Division>().Select(fields).GetAllAsync();

            //foreach(var div in divisions)
            //{
            //    Console.WriteLine($"{div.Code} - {div.CustomerName} - {div.CustomerCode} - {div.Description}");
            //}

            return 0;
        }
	}
}
