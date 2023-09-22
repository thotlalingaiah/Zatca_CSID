using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Zatca_CSID.Models;

namespace Zatca_CSID.ApiHelper
{
    public class ApiRequest
    {
        public static string Register(UserModel user)
        {
            string responseStr = "Error";
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = (new Uri(GlobalVariable.BaseURL));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                HttpResponseMessage result = client.PostAsync(GlobalVariable.RegisterUser, content).Result;
                responseStr = result.Content.ReadAsStringAsync().Result.ToString();
                if (result.IsSuccessStatusCode)
                {
                    return responseStr;
                }
                 
            }
            return responseStr;
        }


        public static UserModel Login(UserModel user)
        {
            UserModel userModel = new UserModel();
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = (new Uri(GlobalVariable.BaseURL));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
               StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                HttpResponseMessage result = client.PostAsync(GlobalVariable.LoginUser, content).Result;
                string str2 = result.Content.ReadAsStringAsync().Result;
                if (result.IsSuccessStatusCode)
                {
                    userModel = JsonConvert.DeserializeObject<UserModel>(str2);
                }



            }
            return userModel;
        }



        public static string GetToken(UserModel user)
        {
            string responseStr = "Error";
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = (new Uri(GlobalVariable.BaseURL));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                HttpResponseMessage result = client.PostAsync(GlobalVariable.GetToken, content).Result;
                responseStr = result.Content.ReadAsStringAsync().Result;
                if (result.IsSuccessStatusCode)
                {
                    return responseStr;
                }



            }
            return responseStr;
        }



        public static CompanyInfo GenerateCSID(CompanyInfo companyInfo)
        {
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = (new Uri(GlobalVariable.BaseURL));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalVariable.TokenString);
                StringContent content = new StringContent(JsonConvert.SerializeObject(companyInfo), Encoding.UTF8, "application/json");
                HttpResponseMessage result = client.PostAsync(GlobalVariable.GenerateCSID, content).Result;
                string str2 = result.Content.ReadAsStringAsync().Result;
                if (result.IsSuccessStatusCode)
                {
                    companyInfo = JsonConvert.DeserializeObject<CompanyInfo>(str2);
                }
                

            }
            return companyInfo;
        }
        public static InvoiceReportingResponse SubmitInvoice(EncodedInvoiceModel invoice)
        {
            InvoiceReportingResponse response = new InvoiceReportingResponse();

            try
            {

                using (HttpClient client = new HttpClient())
                {

                    client.BaseAddress = (new Uri(GlobalVariable.BaseURL));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalVariable.TokenString);
                    StringContent content = new StringContent(JsonConvert.SerializeObject(invoice), Encoding.UTF8, "application/json");
                    HttpResponseMessage result = client.PostAsync(GlobalVariable.Submit2Zatca, content).Result;
                    string str2 = result.Content.ReadAsStringAsync().Result;
                    if (result.IsSuccessStatusCode)
                    {
                        response = JsonConvert.DeserializeObject<InvoiceReportingResponse>(str2);
                    }
                }
            }
            catch (Exception ex)
            {
                response.ErrorMessage = ex.Message;
            }
            return response;

        }
        public static Result EncodeInvoice(_ZInvoice zatcaInvoice)
        {
            string invoiceURL = string.Empty;
            if (zatcaInvoice.InvoiceTypeCode == 388 && zatcaInvoice.InvoiceTypeCodeName == "01") invoiceURL = GlobalVariable.SubmitStandardInvoice;
            if (zatcaInvoice.InvoiceTypeCode == 383 && zatcaInvoice.InvoiceTypeCodeName == "01") invoiceURL = GlobalVariable.SubmitStandardDebitNote;
            if (zatcaInvoice.InvoiceTypeCode == 381 && zatcaInvoice.InvoiceTypeCodeName == "01") invoiceURL = GlobalVariable.SubmitStandardCreditNote;

            if (zatcaInvoice.InvoiceTypeCode == 388 && zatcaInvoice.InvoiceTypeCodeName == "02") invoiceURL = GlobalVariable.SubmitSimplifiedInvoice;
            if (zatcaInvoice.InvoiceTypeCode == 383 && zatcaInvoice.InvoiceTypeCodeName == "02") invoiceURL = GlobalVariable.SubmitSimplifiedDebitNote;
            if (zatcaInvoice.InvoiceTypeCode == 381 && zatcaInvoice.InvoiceTypeCodeName == "02") invoiceURL = GlobalVariable.SubmitSimplifiedCredittNote;


            Result result1 = new Result();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    
                    client.BaseAddress = (new Uri(GlobalVariable.BaseURL));
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalVariable.TokenString);
                    StringContent content = new StringContent(JsonConvert.SerializeObject(zatcaInvoice), Encoding.UTF8, "application/json");
                    HttpResponseMessage result = client.PostAsync(invoiceURL, content).Result;
                    string str2 = result.Content.ReadAsStringAsync().Result;
                    if (result.IsSuccessStatusCode)
                    {
                        result1 = JsonConvert.DeserializeObject<Result>(str2);
                    }

                }
            }
            catch (Exception ex)
            {

                result1.ErrorMessage = ex.ToString();
            }
            return result1;
        }
    }
}
