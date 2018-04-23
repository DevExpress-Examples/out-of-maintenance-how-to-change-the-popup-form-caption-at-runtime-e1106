Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxScheduler
Imports System.Drawing
Imports DevExpress.Web.ASPxClasses.Internal
Imports DevExpress.XtraScheduler

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		DataHelper.SetupMappings(ASPxScheduler1)
		DataHelper.ProvideRowInsertion(ASPxScheduler1, DataSource1.AppointmentDataSource)
		DataSource1.AttachTo(ASPxScheduler1)
	End Sub
	Protected Sub OnAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
		Dim caption As String = "My Appointment caption"
		Dim location As String = e.Appointment.Location
		If (Not String.IsNullOrEmpty(location)) Then
			caption &= String.Format(" - {0}", location)
		End If
		e.Container.Caption = caption
	End Sub
	Protected Sub OnGotoDateFormShowing(ByVal sender As Object, ByVal e As GotoDateFormEventArgs)
		e.Container.Caption = "My go to date caption"
	End Sub

End Class
