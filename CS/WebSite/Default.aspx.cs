using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxScheduler;
using System.Drawing;
using DevExpress.Web.ASPxClasses.Internal;
using DevExpress.XtraScheduler;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e) {
        DataHelper.SetupMappings(ASPxScheduler1);
        DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource);
        DataSource1.AttachTo(ASPxScheduler1);        
    }
    protected void OnAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
        string caption = "My Appointment caption";
        string location = e.Appointment.Location;
        if (!String.IsNullOrEmpty(location)) {
            caption += String.Format(" - {0}", location);
        }
        e.Container.Caption = caption;
    }
    protected void OnGotoDateFormShowing(object sender, GotoDateFormEventArgs e) {
        e.Container.Caption = "My go to date caption";
    }
   
}
