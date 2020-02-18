using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnvioPayLips
{
    public partial class ReportViewer2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowReport();
        }



        private void ShowReport()
        {
            try
            {
                NetworkCredential nwc = new NetworkCredential("administrador", "$SCP.1987!*", "SCP");
                WebClient client = new WebClient();
                client.Credentials = nwc;
                //report url  
                string urlReportServer = "http://10.0.1.7";

                // ProcessingMode will be Either Remote or Local  
                ReportViewer1.ProcessingMode = ProcessingMode.Remote;

                //Set the ReportServer Url  
                ReportViewer1.ServerReport.ReportServerUrl = new Uri(urlReportServer);

                // setting report path  
                //Passing the Report Path with report name no need to add report extension   
                ReportViewer1.ServerReport.ReportPath = "http://10.0.1.7/Reports/Pages/Folder.aspx/Reportes_Desarrollados/ADP_SSRR/SLP_CUSTOM/Reporte_05_SLP_AKamai";

                //Set report Parameter  
                //Creating an ArrayList for combine the Parameters which will be passed into SSRS Report  
                //ArrayList reportParam = new ArrayList();  
                //reportParam = ReportDefaultPatam();  

                //ReportParameter[] param = new ReportParameter[reportParam.Count];  
                //for (int k = 0; k < reportParam.Count; k++)  
                //{  
                //    param[k] = (ReportParameter)reportParam[k];  
                //}  

                // pass credential as if any... no need to pass anything if we use windows authentication  
                //rptViewer.ServerReport.ReportServerCredentials =   
                //  new ReportServerCredentials("UserName", "Password", "domainname");  

                //pass parameters to report  
                //rptViewer.ServerReport.SetParameters(param);   
                ReportViewer1.ServerReport.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}