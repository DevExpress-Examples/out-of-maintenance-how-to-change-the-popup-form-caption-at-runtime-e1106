<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v15.2" Namespace="DevExpress.Web" TagPrefix="dxm" %>

<%@ Register Assembly="DevExpress.XtraScheduler.v15.2.Core, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraScheduler" TagPrefix="cc1" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v15.2" Namespace="DevExpress.Web.ASPxScheduler"
    TagPrefix="dxwschs" %>

<%@ Register Src="~/DefaultObjectDataSources.ascx" TagName="DefaultObjectDataSource" TagPrefix="dds" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dds:DefaultObjectDataSource runat="server" ID="DataSource1" />
        <dxwschs:ASPxScheduler ID="ASPxScheduler1" runat="server" GroupType="Resource" Start="2008-07-15" 
            OnAppointmentFormShowing="OnAppointmentFormShowing" 
            OnGotoDateFormShowing="OnGotoDateFormShowing">
            <Views>
                <DayView>
                    <TimeRulers>
                        <cc1:timeruler></cc1:timeruler>
                    </TimeRulers>
                </DayView>
                <WeekView></WeekView>
                <WorkWeekView Enabled="false"></WorkWeekView>
                <MonthView Enabled="false"></MonthView>
                <TimelineView></TimelineView>
            </Views>
        </dxwschs:ASPxScheduler>
    </div>
    </form>
</body>
</html>