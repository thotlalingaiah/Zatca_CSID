using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatca_CSID.Models
{
    public class ZatcaCSR
    {
        public string CommonName { get; set; }
        public string OrganizationName { get; set; }
        public string UnitName { get; set; }
        public string Location { get; set; }
        public string CountryName { get; set; }
        public string SerialNumber { get; set; }
        public string UniqueID { get; set; }
        public string InvoiceType { get; set; }
        public string Industry { get; set; }
        public bool IsProduction { get; set; } = false;
        public string csr_csr { get; set; }
        public string Key_pem { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class ZatcaCsid
    {
        public string OTP { get; set; }
        public string secret { get; set; }
        public string cert_pem { get; set; }
    }
    public class CompanyInfo
    {
        public ZatcaCSR zatcaCSR { get; set; } = new ZatcaCSR();
        public ZatcaCsid ZatcaCsid { get; set; } = new ZatcaCsid();

    }
    public interface IResultCollection
    {
        int Count { get; }
        void Add(Result obj);
    }
    public class ResultCollection : Collection<Result>, IResultCollection
    {
        void IResultCollection.Add(Result obj)
        {
            base.Add(obj);
        }

        int IResultCollection.Count =>
            base.Count;
    }
    public class Result
    {

        public string EncodedInvoice { get; set; }

        public string ErrorMessage { get; set; }

        public string InvoiceHash { get; set; }

        public bool IsValid { get; set; }

        public ResultCollection lstSteps { get; set; }

        public string Operation { get; set; }

        public string PIH { get; set; }

        public string QRCode { get; set; }

        public string ResultedValue { get; set; }

        public string SingedXML { get; set; }

        public string SingedXMLFileName { get; set; }

        public string UUID { get; set; }
    }

    public class InvoiceReportingResponse
    {
        public string ClearanceStatus { get; set; }

        public string ErrorMessage { get; set; }

        public object QrBuyertStatus { get; set; }

        public object QrSellertStatus { get; set; }

        public string ReportingStatus { get; set; }

        public string validationResults { get; set; }
    }
}
