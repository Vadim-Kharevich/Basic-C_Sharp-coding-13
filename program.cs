        public static string addOrChangeUrlParameter(string url, string param)
        {
            Console.WriteLine(url.IndexOf('='));
            if (url.IndexOf('?') == -1)
            {
                url += "?" + param;
            }
            else
            {
                if (param.IndexOf("2") != 3)
                {
                    url = url.Remove(url.IndexOf('?')+1, url.Length - url.IndexOf('?')-1);
                    url += param;
                    
                }
                if (param.IndexOf("2") == 3)
                {
                    url += "&" + param;
                }
            }
            return url;
        }
