using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_L4_LINQ_Req_
{
    internal class Tools
    {
        public List<Contact> Sorting(List<Contact> list)
        {
            for (int j = 0; j < list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (string.Compare(list[i].Name, list[i + 1].Name) > 0)
                    {
                        var bigger = list[i + 1];
                        var smaller = list[i];
                        list[i] = bigger;
                        list[i + 1] = smaller;
                        continue;
                    }
                }
            }
            
            return list;
        }

        public void ShowAll(List<Contact> list)
        {
            foreach (var contact in list)
            {
                Console.WriteLine(contact.Name + " - " + contact.Number);
            }
        }
    }
}
