<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentHome.aspx.cs" Inherits="GUCera.studentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 602px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="font-size: x-large; color: #00FFFF; background-color: #000000;">
        <h style="font-size:x-large;  position: fixed; right: 45%;">Welcome to GUCera!</h>
        <br />

        <hr style="margin-left: 0px" />

        <div style="width: 280px; height: 247px; float:left;">
           
            <asp:Button ID="Button12" runat="server" Height="40px" OnClick="mobile" Text="Add Mobile Number(s)" Width="1300px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px" ForeColor="Black" />
            <br />
           
            <br />
           
           &nbsp;<asp:Button ID="Button2" runat="server" OnCLick="profile" Text="View Profile" Height="34px" Width="234px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px" />
            <br />
&nbsp;<asp:Button ID="Button3" runat="server" Text="Accepted Courses" OnClick="acceptedC" Height="34px" Width="234px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px"/>
            <br />
&nbsp;<asp:Button ID="Button4" runat="server" Text="Enroll in Course" OnClick="enrollC" Height="34px" Width="234px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px"/>
           &nbsp; 
            <br />
&nbsp;<asp:Button ID="Button5" runat="server" Text="Add Credit Card" OnClick="credit" Height="34px" Width="235px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px"/>
           &nbsp;<br />
&nbsp;<asp:Button ID="Button6" runat="server" Text="View Promocodes" OnClick="promo" Height="34px" Width="236px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px"/>
           &nbsp;
            <br />
            &nbsp;
         </div>

            <div style="width: 275px; float:right; height: 226px;">
                <br />
                <br />
           &nbsp;<asp:Button ID="Button7" runat="server" Text="View Assignment's Content" OnClick="content" Height="34px" Width="235px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px" />
             <br />
&nbsp;<asp:Button ID="Button8" runat="server" Text="Submit Assignment Type" OnClick="submit" Height="34px" Width="235px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px" />
           &nbsp;<br />
&nbsp;<asp:Button ID="Button9" runat="server" Text="View Assignment Grade" OnClick="grade" Height="34px" Width="234px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px" />
           &nbsp;<br />
&nbsp;<asp:Button ID="Button10" runat="server" Text="Add Feedback" OnClick="fb" Height="34px" Width="234px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px" />
           &nbsp;<br />
&nbsp;<asp:Button ID="Button11" runat="server" Text="List Certificates" OnClick="cer" Height="34px" Width="235px" BorderColor="Aqua" BorderStyle="Solid" BorderWidth="2px"/>
            </div>
        
    </form>
</body>
</html>
