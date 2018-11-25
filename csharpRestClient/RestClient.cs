﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;

namespace csharpRestClient
{


    public enum httpVerb
    {

        GET,
        POST,
        PUT,
        DELETE

    }

    class RestClient
    {

        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;

        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            HttpWebResponse response = null;

            try
            {

                response = (HttpWebResponse)request.GetResponse();

                
                using (System.IO.Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {

                            strResponseValue = reader.ReadToEnd();
                        }

                    }
                }
                
            }

            catch (Exception ex)
            {

                strResponseValue = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";

            }

            finally
            {
                if(response!=null)
                {

                    ((IDisposable)response).Dispose();
                }

            }

                return strResponseValue;
        }

    }
}