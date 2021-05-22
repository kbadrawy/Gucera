<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminHome.aspx.cs" Inherits="GUCera.adminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #000000; height: 1096px;">
         <div style="font-family: 'Arial Black'; color: #00FFFF; font-weight: bold; font-size: x-large; background-color: #000000"><h style="font-size:x-large;  position: fixed; right: 45%;">
             <br />
             Welcome to GUCera!</h>
         </div>
             <br />
        <br />
        <div style="width: 339px">
            <asp:Button ID="Button1" runat="server" Text="Add Mobile Number" OnClick="mobile" Width="236px" Height="31px" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="All Cousres" OnClick="allC" Width="237px" Height="29px" />
            <br />
            <asp:Button ID="Button6" runat="server" Text="All Courses Not Yet Accepted" OnClick="notAcc" Width="237px" OnClick="Button6_Click" Height="31px" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Accept Requested Courses" OnClick="acc" Width="237px" Height="31px" />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Create Promo Code" OnClick="createPC" Width="237px" style="margin-right: 0px" Height="30px" />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Issue Promo Code to a Student" OnClick="issuePC" Width="237px" Height="31px" style="margin-right: 0px" />
            <br />
        </div>
    </form>
</body>
</html>