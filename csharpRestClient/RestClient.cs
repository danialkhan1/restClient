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

    public enum authenticationType
    {
        Basic,
        NTLM
    }

    public enum authenticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }

    class RestClient
    {

        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public authenticationType authType { get; set; }
        public authenticationTechnique authTech { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }


        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;

        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();


            if(authTech == authenticationTechnique.RollYourOwn)
            {
                string authHeaer = System.Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(userName + ":" + userPassword));

                request.Headers.Add("Authorization", "Basic " + authHeaer);

            }
            else
            {
                NetworkCredential netCred = new NetworkCredential(userName, userPassword);
                request.Credentials = netCred;
            
            }




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
