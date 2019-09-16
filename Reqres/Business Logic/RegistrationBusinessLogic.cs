using Newtonsoft.Json.Linq;
using RestSharp;
using System;


namespace Reqres.Business_Logic
{
    class RegistrationBusinessLogic
    {
        public static RestClient client;
        public static RestRequest req;
        public static IRestResponse res;
        public bool invoke() {
            try
            {
                client = new RestClient("https://reqres.in/api/");
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Provide_parameter(String username, String password) {
            try
            {
                req.RequestFormat = DataFormat.Json;
                req.AddParameter("email", username);
                req.AddParameter("password", password);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool try_register()
        {
            try
            {
                res = client.Execute(req);
                int response = (int)res.StatusCode;
                if (response == 200)
                {
                    return true;
                }
                else if (response == 400)
                {
                    return false;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool check_for_token() {
            var obj = JObject.Parse(res.Content);
            var token = (string)obj.SelectToken("token");
            if (token != null) {
                
                return true;
            }
            else 
                return false;
        }
        public bool generate_request(String Resource,String Type)
        {
            try
            {
                if (Type.Equals("Get"))
                {
                    req = new RestRequest(Resource, Method.GET);
                    return true;
                }
                else if (Type.Equals("Post"))
                {
                    req = new RestRequest(Resource, Method.POST);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e) {
                return false;
            }
    }
        public bool get_response() {
            res = client.Execute(req);
            if ((int)res.StatusCode == 200)
            {
                var obj = JObject.Parse(res.Content);
                var list = obj.SelectToken("data");
                if (list != null)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
    
}
