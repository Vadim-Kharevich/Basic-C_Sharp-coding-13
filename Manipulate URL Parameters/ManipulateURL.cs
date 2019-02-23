using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_URL_Parameters
{
    public class ManipulateURL
    {
        public static string addOrChangeUrlParameter(string url, string param)
        {
            if (url == null || param == null)
                throw new ArgumentNullException();
            if (url == "" || param == "")
                throw new ArgumentException();
            if (url.IndexOf('?') == -1)
            {
                url += "?" + param;
            }
            else
            {
                string key = param.Remove(param.IndexOf('='));
                if (url.Substring(url.IndexOf("?") + 1, url.IndexOf("=") - url.IndexOf("?") - 1) == key)
                {
                    url = url.Remove(url.IndexOf('?') + 1, url.Length - url.IndexOf('?') - 1);
                    url += param;

                }
                if (url.Substring(url.IndexOf("?") + 1, url.IndexOf("=") - url.IndexOf("?") - 1) != key)
                {
                    url += "&" + param;
                }
            }
            return url;
        }
    }
}
