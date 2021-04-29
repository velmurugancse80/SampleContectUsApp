using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using SampleContactUsApp.Models;

namespace SampleContactUsApp.Utilities
{
    public class Utility
    {
        public void SaveData(ContactUsForm contactUsForm)
        {
            string file = System.Web.HttpContext.Current.Server.MapPath("~/Temp/Sampleapp.txt");
            var list = new List<ContactUsForm>();
            list.Add(contactUsForm);
            var arr = list.ToArray();

            using (StreamWriter writer = new StreamWriter(file))
            {

                foreach (var contact in arr)
                {
                    writer.WriteLine("FirstName :" + contact.FirstName + "\r\n" + "LastName :" + contact.LastName + "\r\n" + "Email :" + contact.Email + "\r\n" + "Message :" + contact.Message);
                }
            }

        }

    }
}