using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatca_CSID.Models
{
    public class GlobalVariable
    {
        public static string BaseURL = "https://zatca.rentro.ae/api/";
        //public static string BaseURL = "https://localhost:44387/api/";
        public static string GenerateCSID = "ZatcaCsid/GenerateCSID";
        public static string GenerateCSIDWithCSR = "ZatcaCsid/GenerateCSIDWithCSR";
        public static string GenerateCSR = "ZatcaCsid/GenerateCSR";
        public static string SampleCSIDData = "ZatcaCsid/SampleData";

        public static string SubmitStandardInvoice          = "ZatcaInvoice/SubmitStandardInvoice";
        public static string SubmitStandardDebitNote        = "ZatcaInvoice/SubmitStandardDebitNote";
        public static string SubmitStandardCreditNote       = "ZatcaInvoice/SubmitStandardCreditNote";
        public static string SubmitSimplifiedInvoice        = "ZatcaInvoice/SubmitSimplifiedInvoice";
        public static string SubmitSimplifiedDebitNote      = "ZatcaInvoice/SubmitSimplifiedDebitNote";
        public static string SubmitSimplifiedCredittNote    = "ZatcaInvoice/SubmitSimplifiedCredittNote";
        public static string Submit2Zatca                   = "ZatcaInvoice/Submit2Zatca";


        public static string RegisterUser = "UserAuthenticate/RegisterUser";
        public static string LoginUser = "UserAuthenticate/Login";
        public static string GetToken = "UserAuthenticate/GetToken";


        private static string _publicKey;

        public static string PublicKey
        {
            get { return _publicKey; }
            set { _publicKey = value; }
        }

        private static string _privateKey;

        public static string PrivateKey
        {
            get { return _privateKey; }
            set { _privateKey = value; }
        }

        private static string _signedKey;

        public static string SignedKey
        {
            get { return _signedKey; }
            set { _signedKey = value; }
        }

        private static string _secretKey;

        public static string SecretKey
        {
            get { return _secretKey; }
            set { _secretKey = value; }
        }


        private static string _userName;

        public static string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private static string _password;

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private static string _tokenString;

        public static string TokenString
        {
            get { return _tokenString; }
            set { _tokenString = value; }
        }


        public DataTable InvoiceHdr=new DataTable();
        public DataTable InvoiceDetail=new DataTable();
            /*InvoiceNumber
            InvoiceDate
            UUID
            HashKey
            XMLFileName
            BillRef
            BillRef_UUID
            BillRef_Notes
            BillRef_PaymentMode
            InvoiceType
            VatCode
            PaymentCode
            Cur_Code
            Tax_Cur_Code
            InvoiceHash
            SignedXML
            EncodedInvoice
            QRCode
            ErrorMessage
            ClearenceStatus
            ReportingStatus
            BoardingDate
            CustomerID
            SupplierID
            InvoiceNotes
            ResponseString*/


    }
}
